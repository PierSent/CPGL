using Microsoft.VisualStudio.TestTools.UnitTesting;
using labGame;
using Racing;
using System.Drawing;

namespace UnitTestTolstych
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()

        {
            Sudoku game = new Sudoku(); //объявление игры судоку
            int test = 3;   //переменная для рассчета ожидаемого размера массива 
            int[,] expected = new int[test * test, test * test]; // рассчет ожидаемого размера массива 
            int[,] actual = game.map;// настоящий массив из программы

            Assert.AreEqual(expected, actual, "Размер массивов не совпадает");// сверяем размер массивов
        }

        [TestMethod]
        public void TestMethod2()

        {
            int x = 1;
            int y = 1;
            Player game = new Player(x, y);//объявление класса играемого персонажа из игры virusgame
            bool expected = true; //ожидаемый результат (вирус живой)
            bool actual = game.isLife;//результат

            Assert.AreEqual(expected, actual, "Вирус родился мертвым...");// сверяем размер массивов
        }

        [TestMethod]
        public void TestMethod3()

        {
            int x = 1;
            int y = 1;
            Road road = new Road(x, y);
            //Image testImage = road.roadImg;// специальная переменная для юнит теста для картинки

            int expected = 790;// высота картинки, какая она есть
            int actual = road.Height; //высота, какую мы определили

            Assert.AreEqual(expected, actual, "Размер картиночки не совпадает с найденной ее высотой");// сверяем размер массивов
        }
    }
}
