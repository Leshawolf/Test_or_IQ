using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]



    public partial class Quest_1 : ContentPage
    {
        List<Question> questionsList;
        public Quest_1()
        {
            InitializeComponent();
            BindingContext = this;
            Question quest1 = new Question("https://pikuco.ru/upload/test_stable/b45/b459d3193dc61f94d68bd83a8897118f.jpg", "C", "М", "А", "Т", "Н", 5);
            Question quest2 = new Question("https://pikuco.ru/upload/test_stable/697/6976a2bb38d6d004ba7443af1da78415.jpg", "22 20", "20 22", "23 21", "23 20", "24 21", 3);
            Question quest3 = new Question("https://pikuco.ru/upload/test_stable/dad/dadc861a71ed2b3e3495b9c5f7bca4b3.jpg", "Н П", "М О", "О Р", "Н О", "М П", 3);
            Question quest4 = new Question("https://pikuco.ru/upload/test_stable/7ab/7ab93198ed6ce47b876f0e94e44ad525.jpg", "41", "27", "14", "43", "32", 1);
            Question quest5 = new Question("https://pikuco.ru/upload/test_stable/cfe/cfe6d2b5df130d88cf374aacbe2f857c.jpg", "365", "340", "320", "350", "380", 4);
            Question quest6 = new Question("https://pikuco.ru/upload/test_stable/9bd/9bd462bbde77a20589eec000443976b2.jpg", "а-ж б-к ё-в е-и д-л з-г м-й", "а-ж б-к м-в г-и д-л з-е ё-й", "а-ж ё-к б-в г-и д-л з-е м-й", "д-ж б-к ё-в г-и а-л з-е м-й", "а-ж б-к ё-в г-и д-л з-е м-й", 3);
            Question quest7 = new Question("https://pikuco.ru/upload/test_stable/e46/e460f6602513896fda9c1a029cb15adb.jpg", "Г Н", "В М", "Е Н", "Е О", "Д М", 4);
            Question quest8 = new Question("https://pikuco.ru/upload/test_stable/081/08140858083fb1d27b8d43a8b22063f6.jpg", "ЛЕВ", "ТИГР", "ГЕПАРД", "ПУМА", "ГИЕНА", 5);
            Question quest9 = new Question("https://pikuco.ru/upload/test_stable/958/9587659682c66a3424537d9f7e48efb6.jpg", "12", "44", "54", "45", "32", 2);
            Question quest10 = new Question("https://pikuco.ru/upload/test_stable/97b/97b871b8d39c6ca67575b1ce3e267d00.jpg", "И", "К", "Р", "Г", "Щ", 2);
            Question quest11 = new Question("https://pikuco.ru/upload/test_stable/b16/b16428d74c1689a8a368f2b53639a63d.jpg", "Л Н", "Л М", "Л О", "К О", "М П", 2);
            questionsList = new List<Question>() { quest1, quest2, quest3, quest4, quest5, quest6, quest7, quest8, quest9, quest10,quest11 };

        }
        int skip = 0, flag = 0,info=0;

        bool check = false;
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (check == true)
            {
                skip++;
                Skiping(skip);
            }
            if(skip>=10)
            {
                Skip.Text = "🔃";
                if(skip>=11)
                {
                    Skip.Text = ">";
                    skip = 0;
                    Skiping(skip);
                }
            }
        }
        private void btn1_Clicked(object sender, EventArgs e)
        {
            if (check == false)
            {
                if (questionsList[skip].otvet == 1)
                {
                    flag++;
                    btn1.BackgroundColor = Color.Green;
                    check = true;
                }
                else
                {
                    check = true;
                    btn1.BackgroundColor = Color.DarkRed;
                }
            }
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            if (check == false)
            {
                if (questionsList[skip].otvet == 2)
                {
                    flag++;
                    check = true;
                    btn2.BackgroundColor = Color.Green;
                }
                else
                {
                    check = true;
                    btn2.BackgroundColor = Color.DarkRed;
                }
            }
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {

            if (check == false)
            {
                if (questionsList[skip].otvet == 3)
                {
                    flag++;
                    check = true;
                    btn3.BackgroundColor = Color.Green;
                    Skip.BackgroundColor = Color.Green;
                }
                else
                {
                    check = true;
                    btn3.BackgroundColor = Color.DarkRed;
                    Skip.BackgroundColor = Color.DarkRed;
                }
            }
        }

        private void btn4_Clicked(object sender, EventArgs e)
        {
            if (check == false)
            {
                if (questionsList[skip].otvet == 4)
                {
                    flag++;
                    check = true;
                    btn4.BackgroundColor = Color.Green;
                    Skip.BackgroundColor = Color.Green;
                }
                else
                {
                    check = true;
                    btn4.BackgroundColor = Color.DarkRed;
                    Skip.BackgroundColor = Color.DarkRed;
                }
            }
        }

        private void btn5_Clicked(object sender, EventArgs e)
        {
            if (check == false)
            {
                if (questionsList[skip].otvet == 5)
                {
                    flag++;
                    check = true;
                    btn5.BackgroundColor = Color.Green;
                    Skip.BackgroundColor = Color.Green;
                }
                else
                {
                    check = true;
                    btn5.BackgroundColor = Color.DarkRed;
                    Skip.BackgroundColor = Color.DarkRed;
                }
            }
        }

        private void startbtn_Clicked(object sender, EventArgs e)
        { 
            startbtn.IsVisible = false;
            lbIQ.IsVisible = false;
            frameosn.IsVisible = true;
            btn1.IsVisible=true; 
            btn2.IsVisible=true;
            btn3.IsVisible=true;
            btn4.IsVisible = true;
            btn5.IsVisible = true;
            last.IsVisible = true;
            Skip.IsVisible = true;
            Skiping(skip);

        }

        private void last_Clicked(object sender, EventArgs e)
        {
            if (skip>=1) { 
            skip--;
            Skiping(skip);
            }
        }

        private async void Skiping(int i)
        {
            if (skip < 10)
            {
                img.Source=questionsList[i].questions1;
                btn1.Text = questionsList[i].variant_1;
                btn2.Text = questionsList[i].variant_2;
                btn3.Text = questionsList[i].variant_3;
                btn4.Text = questionsList[i].variant_4;
                btn5.Text = questionsList[i].variant_5;
                btn1.BackgroundColor = Color.Gray;
                btn2.BackgroundColor = Color.Gray;
                btn3.BackgroundColor = Color.Gray;
                btn4.BackgroundColor = Color.Gray;
                btn5.BackgroundColor = Color.Gray;
                Skip.BackgroundColor = Color.Gray;
                check = false;
                info = 0;
            }
            else
            {
                if (info == 0)
                {
                    if (flag >= 0 && flag < 2)
                    {
                        await DisplayAlert("Тест пройден", $"Вы ответили правильно на {flag} из {questionsList.Count} вопросов", "Окей");
                    }
                    if (flag >= 2 && flag < 5)
                    {
                        await DisplayAlert("Тест пройден", $"Вы ответили правильно на {flag} из {questionsList.Count} вопросов", "Окей");
                    }
                    if (flag >= 5 && flag < 10)
                    {
                        await DisplayAlert("Тест пройден", $"Вы ответили правильно на {flag} из {questionsList.Count} вопросов", "Окей");
                    }
                    if (flag == 10)
                    {
                        await DisplayAlert("Тест пройден", $"Вы ответили правильно на {flag} из {questionsList.Count} вопросов", "Окей");
                    }
                    info++;
                }
            }
        }
       



    }
}