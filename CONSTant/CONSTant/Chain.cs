using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTant
{
    
   public class Customer
    {
        public int Id;
        public string Name;
        public const string idk = "I dont know";


        public Customer( int id) : this(id,"1")
        {
            
        }
        
        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        }
     
       
            
           
           
       
    }

