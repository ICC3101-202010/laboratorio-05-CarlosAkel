using System;
using System.Collections.Generic;
using System.Text;

namespace Solucion_Lab_21_abril
{
    class User
    {
        public delegate void EmailCheckEventHandler(object source, EventArgs args);

        public event EmailCheckEventHandler EmailVerified;

        protected virtual void OnEmailVeridied()
        {
            if(EmailVerified != null)
            {
                EmailVerified(this, EventArgs.Empty);
            }
        }

        public void OnEmailSent(object source, EventArgs args)
        {
            Console.WriteLine("Do you want to verify your email? (yes/no)");
            string answ = Console.ReadLine();
            if (answ == "yes")
            {
                OnEmailVeridied();
            }
            else
            {

            }
        }
    }
}
