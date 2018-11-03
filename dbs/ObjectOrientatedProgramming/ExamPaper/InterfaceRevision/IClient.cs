using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.ExamPaper.InterfaceRevision
{
    interface IClient
    {
        string Email { get; set; }
        string GreetClient();
        string DirectClient();


    }
}
