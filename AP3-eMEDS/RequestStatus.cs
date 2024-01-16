using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP3_eMEDS
{
    public class RequestStatus
    {
        public bool success { get; set; }
        public typeError typeError { get; set; }

        // constructor
        public RequestStatus() {}

        // func to get success value with MySqlCommand.ExecuteNonQuery()
        public RequestStatus GetRequestStatusNoError(int result)
        {
            this.success = result == 1;
            this.typeError = typeError.NoError;
            return this;
        }

        // func to return RequestStatus with error
        public RequestStatus GetRequestStatusError(typeError type)
        {
            this.success = false;
            this.typeError = type;
            return this;
        }
    }
}
