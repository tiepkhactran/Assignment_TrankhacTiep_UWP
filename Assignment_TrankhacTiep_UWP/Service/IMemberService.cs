using Assignment_TrankhacTiep_UWP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_TrankhacTiep_UWP.Service
{
    interface IMemberService
    {
        Member Register(Member member);

        MemberCredential Login(Memberlogin memberlogin);

        Member GetInformation(string token);
    }
}
