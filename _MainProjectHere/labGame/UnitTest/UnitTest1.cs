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
            Sudoku game = new Sudoku(); //���������� ���� ������
            int test = 3; //���������� ��� �������� ���������� ������� �������
            int[,] array = new int[test * test, test * test]; // ������� ���������� ������� �������
            int expected = array.Length;
            int actual = game.map.Length;// ��������� ������ �� ���������

            Assert.AreEqual(expected, actual, "������ �������� �� ���������");// ������� ������ ��������
        }

        [TestMethod]
        public void TestMethod2()

        {
            int x = 1;
            int y = 1;
            Player game = new Player(x, y);//���������� ������ ��������� ��������� �� ���� virusgame
            bool expected = true; //��������� ��������� (����� �����)
            bool actual = game.isLife;//���������

            Assert.AreEqual(expected, actual, "����� ������� �������...");// ������� ������ ��������
        }
        [TestMethod]
        public void TestMethod3()

        {
            int x = 110;
            int y = 0;
            Road road = new Road(x, y);
            //Image testImage = road.roadImg;// ����������� ���������� ��� ���� ����� ��� ��������

            int expected = 790;// ������ ��������, ����� ��� ����
            int actual = Road.Height; //������, ����� �� ����������

            Assert.AreEqual(expected, actual, "������ ���������� �� ��������� � ��������� �� �������");// ������� ������ ��������
        }
        [TestMethod]
        public void TestMethod4()

        {
            string inputTest = "123456";// �������� ����� � ���� string

            bool expected = true;// ��������� ���������
            bool actual = Game15.isInt(inputTest); //���� �������, ����� �� ����������

            Assert.AreEqual(expected, actual, "��� ������ �� int");// ������� ����������
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

              Assert.AreEqual(expected, actual, "����");// ������� ������ ��������
          }*/
    }
}
