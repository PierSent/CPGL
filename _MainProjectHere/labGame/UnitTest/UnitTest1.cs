using Microsoft.VisualStudio.TestTools.UnitTesting;
using labGame;
using Racing;
using System.IO;
using System.Data.SqlClient;
using lab15;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()

        {
            Sudoku game = new Sudoku(); //объ€вление игры судоку
            int test = 3; //переменна€ дл€ рассчета ожидаемого размера массива
            int[,] array = new int[test * test, test * test]; // рассчет ожидаемого размера массива
            int expected = array.Length;
            int actual = game.map.Length;// насто€щий массив из программы

            Assert.AreEqual(expected, actual, "–азмер массивов не совпадает");// свер€ем размер массивов
        }

        [TestMethod]
        public void TestMethod2()

        {
            int x = 1;
            int y = 1;
            Player game = new Player(x, y);//объ€вление класса играемого персонажа из игры virusgame
            bool expected = true; //ожидаемый результат (вирус живой)
            bool actual = game.isLife;//результат

            Assert.AreEqual(expected, actual, "¬ирус родилс€ мертвым...");// свер€ем размер массивов
        }
        [TestMethod]
        public void TestMethod3()

        {
            int x = 110;
            int y = 0;
            Road road = new Road(x, y);
            //Image testImage = road.roadImg;// специальна€ переменна€ дл€ юнит теста дл€ картинки

            int expected = 790;// высота картинки, кака€ она есть
            int actual = Road.Height; //высота, какую мы определили

            Assert.AreEqual(expected, actual, "–азмер картиночки не совпадает с найденной ее высотой");// свер€ем размер картинок
        }
        [TestMethod]
        public void TestMethod4()

        {
            string inputTest = "123456";// проверка числа в типе string

            bool expected = true;// ожидаемый результат
            bool actual = Game15.isInt(inputTest); //сама функци€, какую мы определили

            Assert.AreEqual(expected, actual, "тип строки не int");// свер€ем результаты
        }
        /*  [TestMethod]   govnoooooo
          public void TestMethod4()

          {
              var finalDist = 3004;
              object[,] cars = new object[3, 4]
              {   {"classic", true, true, 0},
                  {"green", false, false, 50},
                  {"neon", false, false, 100}   };
              Game g = new Game(0, 1000, cars);

              g.moreVelocity(finalDist);


              int expected = 9;
              int actual = g.velocity;

              Assert.AreEqual(expected, actual, "жопа");// свер€ем размер картинок
          }*/
    }
}
