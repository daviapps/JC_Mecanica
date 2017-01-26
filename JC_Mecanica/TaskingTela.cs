using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC_Mecanica {
    abstract class TaskingTela {
        private System.Windows.Forms.Timer backTask;

        public void init() {
            this.backTask = new System.Windows.Forms.Timer();
            //this.backTask.Tick += new EventHandler(this.backTasking);
            this.backTask.Interval = 100;
            this.backTask.Start();
        }

        protected void stopTask() {
            this.backTask.Stop();
        }

        //protected void backTasking(object sender, EventArgs e);
    }
}
