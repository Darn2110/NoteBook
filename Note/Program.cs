using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note
{
   public class Information
    {
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Secondname { get; set; }
        public long PhoneNumber { get; set; }
        public string Country { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Organization { get; set; }
        public string Position { get; set; }
        public string OtherNotes { get; set; }

      

        public void Recording( List<Information> id)
        {
            
            Console.Write("\n");
            Console.WriteLine("Фамилия: " + Surname);
            Console.WriteLine("Имя: " + Firstname);
            Console.WriteLine("Отчество: " + Secondname);
            Console.WriteLine("Номер телефона: " + PhoneNumber);
            Console.WriteLine("Страна: " + Country);
            
            if (DateOfBirth != DateTime.MinValue)
            {
                Console.WriteLine("День рождения: " + DateOfBirth.ToString("d"));
            }
            else
            {
                Console.WriteLine("День рождения: ");
            }
            Console.WriteLine("Организация: " + Organization);
            Console.WriteLine("Должность: " + Position);
            Console.WriteLine("Прочее: " + OtherNotes);
        }

        public void ShortEntry(List<Information> id)
        {
            Console.Write("\n");
            Console.WriteLine("Фамилия: " + Surname);
            Console.WriteLine("Имя: " + Firstname);
            Console.WriteLine("Номер телефона: " + PhoneNumber);
        }

        public static void Delete(List<Information> id)
        {
            string s;
           
            
            Console.WriteLine("Для того чтобы удалить запись, введите номер записи.");
            Console.WriteLine("Чтобы прекратить удаление введите значение: -1");
            Console.WriteLine("\n");
            Console.Write("Введите номер: ");
            
            
            while (true)
            {
                
                s = Console.ReadLine();
                bool dell = int.TryParse(s, out int delf);
                
                int last_index = id.Count - 1;
                if (delf > -1 && delf != -1 && delf <= last_index && dell == true)
                {
                    id.RemoveAt(delf);
                    Console.WriteLine("Запись с номером: " + s + " удалена!");
                    continue;
                }
                else if (delf > last_index || delf < -1 || dell == false)
                {
                    Console.WriteLine("Такой записи не существует!");
                    Console.Write("Введите номер: ");
                    continue;
                }
                else if(delf == -1)
                {
                    Console.WriteLine("Удаление завершено!");
                    break;
                }
            }
        }
            public static void Editing(List<Information> id)
            {
                string q;
                
                 
                Console.WriteLine("Чтобы отредактировать запись, введите её номер:");
                Console.WriteLine("Чтобы прекратить редактирование введите значение: -1");
                
                while (true)
                {

                    Console.Write("Введите номер: ");
                    q = Console.ReadLine();
                    bool edi = int.TryParse(q, out int edit);
                    
                    int last_index = id.Count - 1;
                    if (edit > -1 && edit != -1 && edit <= last_index && edi == true)
                    {
                            Console.Write("\n");
                            Console.Write("Фамилия: ");
                            string surname = Console.ReadLine();
                            while (surname == "")
                            {
                                Console.Write("Поле обязательное! Повторите попытку: ");
                                surname = Console.ReadLine();
                            }
                            
                            Console.Write("Имя: ");
                            string firstname = Console.ReadLine();
                            while (firstname == "")
                            {
                                Console.Write("Поле обязательное! Повторите попытку: ");
                                firstname = Console.ReadLine();
                            }
                            
                            Console.Write("Отчество (поле не является обязательным): ");
                            string secondname = Console.ReadLine();
                            
                            Console.Write("Номер телефона: ");
                            
                            string phoneNumber = Console.ReadLine();
                            bool result = long.TryParse(phoneNumber, out long numb);
                   
                            while (result == false)
                            {
                                Console.Write("Номер может состоять только из цифр! Повторите попытку: ");
                                phoneNumber = Console.ReadLine();
                                result = long.TryParse(phoneNumber, out long numbp);
                                numb = numbp;


                            }
                            Console.Write("Страна: ");
                            string country = Console.ReadLine();
                            while (country == "")
                            {
                                Console.Write("Поле обязательное! Повторите попытку: ");
                                country = Console.ReadLine();
                            }
                            Console.Write("День рождения в формате DD.MM.YYYY (поле не является обязательным): ");
                            string time = Console.ReadLine();
                            bool t = DateTime.TryParse(time, out DateTime day);

                            while (time != "")
                            {
                                
                                if (t == false)
                                {
                                    Console.Write("День рождения состоит только из цифр (DD.MM.YYYY)! Повторите попытку: ");

                                    time = Console.ReadLine();
                                    t = DateTime.TryParse(time, out DateTime dayt);
                                    day = dayt;
                                    continue;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            Console.Write("Организация (поле не является обязательным): ");
                            string organization = Console.ReadLine();
                            Console.Write("Должность (поле не является обязательным): ");
                            string position = Console.ReadLine();
                            Console.Write("Прочее (поле не является обязательным): ");
                            string otherNotes = Console.ReadLine();

                        id[edit] = new Information() { Surname = surname, Firstname = firstname, Secondname = secondname, PhoneNumber = numb, Country = country, DateOfBirth = day, Organization = organization, Position = position, OtherNotes = otherNotes };
                        Console.WriteLine("\n");
                        continue;
                    }
                    else if (edit > last_index || edit < -1 || edi == false)
                    {
                        Console.WriteLine("Такой записи не существует!");
                        
                        continue;
                    }
                    else if(edit == -1)
                    {
                        Console.WriteLine("Редактирование завершено!");
                        break;
                    }
                }

            }


       public static List<Information> id = new List<Information>();

        static void Main(string[] args)
        {

            

                int num = 1;
                while (num != 0)
                {
                
                    int i = 0;
                    Console.WriteLine("________________________________________________________________________________________________");
                    Console.Write("\n");
                    Console.WriteLine("Записная книжка.");
                        Console.WriteLine("1 - Создать новую запись. 2 - Просмотр всех созданных учетных записей. 3 - Просмотр всех записей в коротком виде." + "\n" + "4 - Удаление записей. 5 - Редактирование записей. 0 - Выход");
                    Console.Write("Номер команды: ");
                    string nym = Console.ReadLine();
                    bool comNum = int.TryParse(nym, out int res);
                   
                    while (true)
                    {
                       
                        if ((res < 0 || res > 5) || comNum == false)
                        {
                            Console.Write("\n");
                            Console.Write("Такой команды нет! Повторите попытку: ");
                            nym = Console.ReadLine();
                            comNum = int.TryParse(nym, out int rest);
                            res = rest;
                        }
                        else
                        {
                            break;
                        }
                    
                    }
                
               
                        switch (res)
                        {
                            case 1:
                       
                            while (i < 5000)
                            {
                            
                                Console.WriteLine("________________________________________________________________________________________________");
                                Console.Write("\n");
                                Console.WriteLine("Создание новой записи: ");
                                Console.Write("\n");
                                Console.Write("Фамилия: ");
                                string surname = Console.ReadLine();
                                while (surname == "")
                                {
                                    Console.Write("Поле обязательное! Повторите попытку: ");
                                    surname = Console.ReadLine();
                                }
                        
                                Console.Write("Имя: ");
                                string firstname = Console.ReadLine();
                                while (firstname == "")
                                {
                                    Console.Write("Поле обязательное! Повторите попытку: ");
                                    firstname = Console.ReadLine();
                                }
                        
                                Console.Write("Отчество (поле не является обязательным): ");
                                string secondname = Console.ReadLine();
                       
                                Console.Write("Номер телефона: ");
                                   
                                    string phoneNumber = Console.ReadLine();
                                    bool result = long.TryParse(phoneNumber, out long numb);
                                while (result == false)
                                {
                                        Console.Write("Номер может состоять только из цифр! Повторите попытку: ");
                                        phoneNumber = Console.ReadLine();
                                        result = long.TryParse(phoneNumber, out long numbp);
                                        numb = numbp;
                                

                                }
                            
                            
                                Console.Write("Страна: ");
                                string country = Console.ReadLine();
                                while (country == "")
                                {
                                    Console.Write("Поле обязательное! Повторите попытку: ");
                                    country = Console.ReadLine();
                                }
                                Console.Write("День рождения в формате DD.MM.YYYY (поле не является обязательным): ");
                                    string time = Console.ReadLine();
                                    bool t = DateTime.TryParse(time, out DateTime day);
                                    
                                while (time!="")
                                {
                                    
                                    if (t == false)
                                    {
                                        Console.Write("День рождения состоит только из цифр (DD.MM.YYYY)! Повторите попытку: ");

                                        time = Console.ReadLine();
                                        t = DateTime.TryParse(time, out DateTime dayt);
                                        day = dayt;
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                    
                                    
                                    
                                }



                                Console.Write("Организация (поле не является обязательным): ");
                                string organization = Console.ReadLine();
                                Console.Write("Должность (поле не является обязательным): ");
                                string position = Console.ReadLine();
                                Console.Write("Прочее (поле не является обязательным): ");
                                string otherNotes = Console.ReadLine();

                        
                                    id.Add(new Information() {Surname = surname, Firstname = firstname, Secondname = secondname, PhoneNumber = numb, Country = country, DateOfBirth = day, Organization = organization, Position = position, OtherNotes = otherNotes });
                            
                                    break;
                            }
                                i++;
                            

                                break;

                            case 2:
                            foreach (Information a in id)
                            {
                                Console.WriteLine("________________________________________________________________________________________________");
                                Console.Write("\n");
                                Console.WriteLine("Запись: " +  id.IndexOf(a));
                                a.Recording(id);
                            }
                                break;
                            case 3:
                            foreach (Information a in id)
                            {
                                Console.WriteLine("________________________________________________________________________________________________");
                                Console.Write("\n");
                                Console.WriteLine("Короткая запись: " + id.IndexOf(a));
                                a.ShortEntry(id);
                            }
                                break;
                            case 4:
                            Console.WriteLine("________________________________________________________________________________________________");
                            Console.Write("\n");
                            Delete(id);

                            
                                break;
                            case 5:
                            Console.WriteLine("________________________________________________________________________________________________");
                            Console.Write("\n");
                            Editing(id);


                                break;
                            case 0:
                                num = 0;
                                break;  
                            default:
                                break;
                        }
                }
               
            
        }
    }
}
