using System;
using System.Collections.Generic;
using System.Text;

namespace names_menu
{
    public class person
    {
        /// <summary>       


        /// Get Or Set Person Name
        /// </summary>
        public string Name { get; set; }
           
            /// <summary>
            /// get phone number
            /// </summary>
            public string PhoneNumber { get; set; }

        
        public string getName()
        {
            return "Person Name:"+this.Name + @"
Person Phonenumber:"+ this.PhoneNumber;
        }



        public string getNumber()
        {
            return "Person Name:" + this.Name + @"
Person Phonenumber:" + this.PhoneNumber;
        }



        public string information
            {
                get
                {
                    return $@"person
               Name: {Name }
              
               Phone Number : {PhoneNumber }";
                }
            }

            public override string ToString()
            {
                return information;
            }

       
    }
    }

        
    
