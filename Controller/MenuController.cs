using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula.Controller
{
    public class MenuController
    {
        private void NewCust () {

        }

        public void Run (int option) {
            switch (option)
            {
                case 1: this.NewCust(); break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;
            }
        }

        public static MenuController Instance() {
            return new MenuController();
        }
    }
}