﻿using BusinessObjects_EF_IO;
using Repository_EF_IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_EF_IO
{
    public class AccountMemberService : IAccountMemberService
    {
        IAccountMemberRepository accountMemberRepository = new AccountMemberRepository();
        public AccountMember Login(string email, string password)
        {
            return accountMemberRepository.Login(email, password);
        }
    }
}
