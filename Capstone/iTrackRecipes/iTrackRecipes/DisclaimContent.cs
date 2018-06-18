using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTrackRecipes
{
    class DisclaimContent
    {
        public static string Content { get; set; }

        public string DisclaimerContent()
        {
            string disclaimer = "This software is provided \"AS IS\" without warranty of any kind. We make no" +
                                " warranties, expressed or implied, that it is free of error, or is consistent " +
                                "with any particular standard of merchantability, or that it will meet your " +
                                "requirements for any particular application. It should not be relied on for " +
                                "solving a problem whose incorrect solution could result in injury to a person " +
                                "or loss of property. If you do use them in such a manner, it is at your own risk. " +
                                " The user of the software is responsible for securing the data entered into the " +
                                "application database using his or her device security features. The software " +
                                "does not claim to provide any data security features. The author and publisher " +
                                "disclaim all liability for direct, indirect, or consequential damages resulting " +
                                "from your use of the software.";

            {
                return disclaimer;
            }
        }
    }
}
