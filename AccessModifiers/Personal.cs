using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Personal
    {
        string username;
        string userpsw;
        string email;

        public Personal(string username)
        {
            System.Windows.Forms.MessageBox.Show("1 parametreli");
            userInfo();
           // Control(username," " , " ");
        }

        public Personal(string username, string userpsw)
        {
            System.Windows.Forms.MessageBox.Show("2 parametreli");
            userInfo();
           // Control(username, userpsw," ");
        }

        public Personal(string username, string userpsw, string email)
        {
            System.Windows.Forms.MessageBox.Show("3 parametreli");
            userInfo();
           // Control(username, userpsw,email);
        }

        public string Control(string username, string userpsw, string email)
        {
            if (username.Length>=5)
            {
                if (userpsw.Length>=6)
                {
                    if (email.Contains('@')&& email.Contains('.')&& email.Length>13)
                    {
                        this.username = username;
                        this.userpsw = userpsw;
                        this.email = email;
                        return "Kullanıcı bilgileri sisteme kayıtlı değildir.";
                    }
                    else
                    {
                        return "Mail adresi tanımsız girildi.";
                    }
                }
                else
                {
                    return "Kullanıcı sifresi 6 karakteri sağlamaz.";
                }
            }
            else
            {
                return "Kullanıcı ismi 5 karakterden kısa olamaz.";
            }
        }


        public string userInfo()
        {
            if (username!=null)
            {
                if (username!=null&&userpsw!=null)
                {
                    if (username!=null && userpsw != null&&email!=null)
                    {
                        
                        return " Kullanıcı Adı :  \n"+ username+ "Kullanıcı Sifresi:  \n"+ userpsw + "Kullanıcı Adı:  \n"+email;
                    }
                    else
                    {
                        
                        return "Kullanıcı Adı:  \n"+ username+ "Kullanıcı Sifresi:  \n"+ userpsw ;
                    }
                }
                else
                {
                   
                    return  "Kullanıcı Adı :  \n" + username ;
                }
            }
            else
            {
               return "Kullanıcı yok";
            }
        }



    }
}
