﻿using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace common.core
{
    public class SqlService : IHeadstream
    {
        public void _headSerialize(ISerialize nSerialize) {
            nSerialize._serialize(ref mConnectionString,
                @"connectionString");
        }

        public string _streamName() {
            return @"sqlService";
        }

        public bool _runSqlCommand(SqlCommand nSqlCommand) {
            bool result_ = true;
            MySqlConnection mySqlConnection_ =
                new MySqlConnection(mConnectionString);
            try {
                mySqlConnection_.Open();
                MySqlCommand mySqlCommand_ = new MySqlCommand();
                mySqlCommand_.Connection = mySqlConnection_;
                string sqlCommand_ = nSqlCommand._sqlCommand();
                mySqlCommand_.CommandText = sqlCommand_;
                IList<SqlParameter> fields_ =
                    nSqlCommand._getFields();
                foreach (SqlParameter i in fields_) {
                    string name_ = i._getName();
                    object value_ = i._getValue();
                    mySqlCommand_.Parameters.AddWithValue(name_, value_);
                }
                mySqlCommand_.ExecuteNonQuery();
            } catch (MySqlException exception_) {
                LogService logService_ = 
                    __singleton<LogService>._instance();
                string logError = 
                    string.Format(@"sqlError:{0},{1}", 
                    exception_.Number, exception_.Message);
                logService_._logError(logError);
                result_ = false;
            }
            mySqlConnection_.Close();
            return result_;
        }

        public bool _runSqlCommand(SqlCommand nSqlCommand,
            ISqlHeadstream nSqlHeadstream) {
            bool result = true;
            MySqlConnection mySqlConnection_ =
                new MySqlConnection(mConnectionString);
            try {
                mySqlConnection_.Open();
                string sqlCommand_ = nSqlCommand._sqlCommand();
                MySqlCommand mySqlCommand_ =
                    new MySqlCommand(sqlCommand_, mySqlConnection_);
                MySqlDataReader mySqlDataReader_ =
                    mySqlCommand_.ExecuteReader();
                SqlReader sqlReader_ =
                    new SqlReader(mySqlDataReader_);
                while (sqlReader_._runRead()) {
                    nSqlHeadstream._runSelect(sqlReader_);
                }
                sqlReader_._runClose();
            } catch (MySqlException exception_) {
                LogService logService_ = 
                    __singleton<LogService>._instance();
                string logError = 
                    string.Format(@"sqlError:{0},{1}", 
                    exception_.Number,
                    exception_.Message);
                logService_._logError(logError);
                result = false;
            }
            mySqlConnection_.Close();
            return result;
        }

        public void _runPreinit() {
            this._initConfig();
        }

        void _initConfig() {
            string sqlUrl_ = @"config/sqlConfig.xml";
            XmlReader xmlReader_ = new XmlReader();
            xmlReader_._openUrl(sqlUrl_);
            xmlReader_._selectStream(_streamName());
            this._headSerialize(xmlReader_);
            xmlReader_._runClose();
        }

        public SqlService() {
            mConnectionString = null;
        }

        string mConnectionString;
    }
}
