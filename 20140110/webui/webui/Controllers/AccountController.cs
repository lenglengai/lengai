using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using common.core;
using account.core;

namespace webui.Controllers
{
    public class AccountController : WebUIApiController
    {
        [HttpPost]
        public string _createAccount(AccountCreateS nAccountCreateS)
        {
            NewsMgr newMgr = this._checkPacket(nAccountCreateS);
            if (null == newMgr){

            }
            return this._getMessage(newMgr);
        }
    }
}
