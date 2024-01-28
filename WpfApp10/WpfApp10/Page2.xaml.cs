using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp10
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        private int story = 0;
        public Page2()
        {
            InitializeComponent();
            UpdateStory();
        }

        private void ButtonA_CLick(object sender, RoutedEventArgs e)
        {
            story++;
            UpdateStory();
        }

        private void ButtonB_CLick(object sender, RoutedEventArgs e)
        {
            story += 2;
            UpdateStory();
        }
        private void UpdateStory()
        {
            switch (story)
            {
                case 0:
                    Background("2.png");
                    SetStory("Вы родились в мире магов, но у вас нет магии. Ваши действия?");
                    SetOptions("Продолжать жить в лесу", "Начать тренироваться");
                    break;
                case 1:

                    SetStory("Вы живете в лесу с дедушкой, который рекомендует начать тренироваться. Ваши действия?");
                    SetOptions("Начать тренироваться", "Начать тренироваться");
                    break;
                case 2:

                    SetStory("У вас неограниченная физическая сила но у вас нет магии. Ваши действия?");
                    SetOptions("Продолжать тренироваться", "Попробовать колдовать");
                    break;
                case 3:

                    SetStory("Вы помогаете дедушке по хозяйству, но к вам приходит человек из гвардии. Ваши действия?");
                    SetOptions("Попробовать колдовать", "Продожать жизнь в лесу");
                    break;
                case 4:

                    SetStory("У вас не получилось колдовать, по законам магов таких людей не должно быть. Ваши действия?");
                    SetOptions("Продожать жизнь в лесу", "Договориться с гвардейцем");
                    break;
                case 5:

                    SetStory("Постоянные посещения гвардии не оставляют вас в покое. Ваши действия?");
                    SetOptions("Договориться с гвардейцем", "Сразиться");
                    break;
                case 6:

                    SetStory("Вы решили переехать и скрыться от гвардии, но гвардеец не согласен. Ваши действия?");
                    SetOptions("Сразиться", "Выслушать его условия");
                    break;
                case 7:

                    SetStory("Вы сразили гвардейца одним ударом, но вы добрый человек и выслушаете его. Ваши действия?");
                    SetOptions("Выслушать его условия", "Спросить совет деда");
                    break;
                case 8:

                    SetStory("Он предлагает вам вступить в школу магии. Ваши действия?");
                    SetOptions("Спросить совет деда", "Поступить в школу магии");
                    break;
                case 9:

                    SetStory("Дедушка предложил идти в школу магии. Ваши действия?");
                    SetOptions("Поступить в школу магии", "Спросить у гвардейца условия");
                    break;
                case 10:

                    SetStory("Вы поступили в школу магии. Ваши действия?");
                    SetOptions("Спросить у гвардейца условия", "Познакомиться с одногруппниками");
                    break;
                case 11:

                    SetStory("Гапрдеец желает разузнать о происходящем в школе и просит его информировать. Ваши действия?");
                    SetOptions("Познакомиться с одногруппниками", "Согласиться на условия");
                    break;
                case 12:

                    SetStory("Вы удачно познакомились с вашим новым другом, который является слабейшим магом в школе. Ваши действия?");
                    SetOptions("Согласиться на условия гвардейца", "Пойти на первые занятия");
                    break;
                case 13:

                    SetStory("Вы сдали отчет о школе гвардейцу. Ваши действия?");
                    SetOptions("Пойти на первые занятия", "Пойти тренироваться");
                    break;
                case 14:

                    SetStory("Вы на первом занятии магии, но у вас не получается колдовать. Ваши действия?");
                    SetOptions("Пойти тренироваться", "Пойти есть профитроли");
                    break;
                case 15:

                    SetStory("Вы удачно потренировались и проголодались. Ваши действия?");
                    SetOptions("Пойти есть профитроли", "Пропустить обед");
                    break;
                case 16:

                    SetStory("Вы все еще голодны. Ваши действия?");
                    SetOptions("Пропустить обед", "Пойти на кухню");
                    break;
                case 17:

                    SetStory("Вы умираете от голода. Ваши действия?");
                    SetOptions("Пойти на кухню", "Съесть профитроли");
                    break;
                case 18:

                    SetStory("Вы на кухне и готовите профитроли. Ваши действия?");
                    SetOptions("Съесть профитроли", "Пойти разузнать о происходящем в школе");
                    break;
                case 19:

                    SetStory("Вы побороли аппетит. Ваши действия?");
                    SetOptions("Пойти разузнать о происходящем в школе", "Отдохнуть");
                    break;
                case 20:

                    SetStory("Вы узнаете что в школе есть сильнейший маг который превращает учеников в кукол. Ваши действия?");
                    SetOptions("Отдохнуть", "Сразиться");
                    break;
                case 21:

                    SetStory("Вам не дает покоя ситуация с магом. Ваши действия?");
                    SetOptions("Сразиться", "");
                    break;
                case 22:

                    SetStory("Маг нападает на вас. Ваши действия?");
                    SetOptions("Бежать", "Сражаться");
                    break;
                case 23:

                    SetStory("У вас нет выбора как только сражаться. Ваши действия?");
                    SetOptions("Сражаться", "");
                    break;
                case 24:

                    SetStory("Вы сразили мага одним ударом. Ваши действия?");
                    SetOptions("Разузнать о школе", "Доложить в отчете");
                    break;
                case 25:

                    SetStory("Вы разузнали о ситуации в школе. Ваши действия?");
                    SetOptions("Доложить в отчете", "Сходить к директору");
                    break;
                case 26:

                    SetStory("Вы доложили отчет, но вас отправляют к директору. Ваши действия?");
                    SetOptions("Сходить к директору", "");
                    break;
                case 27:

                    SetStory("Вы находитесь у директора и он понимает что вы без магии. Ваши действия?");
                    SetOptions("Отказаться от школы", "Продолжить обучение");
                    break;
                case 28:

                    SetStory("Директор и гвардеец настаивают на вашем обучении. Ваши действия?");
                    SetOptions("Продолжить обучение", "");
                    break;
                case 29:

                    SetStory("Вы продолжаете обучение и являетесь сильнейшим.");
                    SetOptions("Конец", "Конец");
                    break;
                default:
                    SetStory("Игра кончилась, спасибо за игру!");
                    SetOptions("", "");
                    break;
            }
        }
        private void SetStory(string text)
        {
            var fadeInAnumation = new DoubleAnimation(0,1, TimeSpan.FromSeconds(1));
            storyText.BeginAnimation(TextBlock.OpacityProperty, fadeInAnumation);
            storyText.Text = text;
        }
        private void SetOptions(string optionA, string optionB)
        {
            var fadeInAnumation = new DoubleAnimation(0, 1, TimeSpan.FromSeconds(1));
            ButtonA.BeginAnimation(TextBlock.OpacityProperty, fadeInAnumation);
            ButtonB.BeginAnimation(TextBlock.OpacityProperty, fadeInAnumation);

            ButtonA.Content = optionA;
            ButtonB.Content = optionB;
        }
        private void Background(string image)
        {
            var fadeInAnumation = new DoubleAnimation(0, 1, TimeSpan.FromSeconds(1));
            backgoundImage.BeginAnimation(Image.OpacityProperty, fadeInAnumation);
            backgoundImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(image));
        }
    }
}
