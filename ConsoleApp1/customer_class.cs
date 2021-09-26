using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class customer_class
    {
        private int id, mobile_num;
        private string cname, email;

        public void set_data(int ID, int mno, string cn, string em)
         
        {
            this.id = ID;
            this.mobile_num = mno;
            this.cname = cn;
            this.email = em;
        }

        public int get_data()
        { return this.id; }
    }
}
