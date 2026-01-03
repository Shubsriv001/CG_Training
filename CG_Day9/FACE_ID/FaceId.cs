using System;
using System.Security.Cryptography.X509Certificates;

namespace Security.Authentication
{
    
class FaceID
{

  class FacialFeatures
    {
       public string EyeColor;
       public decimal PhiltrumWidth;
       


       public FacialFeatures(string eyeColor, decimal philtrumWidth)
        {
         
                EyeColor=eyeColor;
                PhiltrumWidth=philtrumWidth;
        }

    }

// ---------------------------------------------------------------------------------------

    class Identity
    {

           
           public string Email;
           public FacialFeatures facialFeatures;
        Identity(string email, FacialFeatures facialFeatures)
        {
            Email=email;
            this.facialFeatures=facialFeatures;
        }
        
    }


// ---------------------------------------------------------------------------------------


    class Authenticator
    {
        
    }

    

}
}