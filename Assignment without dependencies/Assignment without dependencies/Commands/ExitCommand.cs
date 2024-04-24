using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataXAssignment.Commands
{
    public class ExitCommand
    {
        public void Execute()
        {
            Environment.Exit(0);
        }
    }
}
