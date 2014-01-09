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
    public class AccountController : NewsController
    {
        [HttpPost]
        public string _createAccount(AccountCreateS nAccountCreateS)
        {
        }
    }
}
