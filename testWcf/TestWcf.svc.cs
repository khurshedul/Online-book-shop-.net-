using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using testWcf;



    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
namespace testWcf {
    [AspNetCompatibilityRequirements(RequirementsMode= AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1 : ITestWcf
    {



            
        public BookEntity GetuserTypeDetails()
        {
            BookEntity result = new BookEntity();
            BookBll bk = new BookBll();
            result.userlist = bk.GetuserTypeDetails().userlist ;
            return result;


        
        }
    }

}