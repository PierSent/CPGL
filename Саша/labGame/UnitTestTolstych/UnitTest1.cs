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
            Sudoku game = new Sudoku(); //���������� ���� ������
            int test = 3;   //���������� ��� �������� ���������� ������� ������� 
            int[,] expected = new int[test * test, test * test]; // ������� ���������� ������� ������� 
            int[,] actual = game.map;// ��������� ������ �� ���������

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
            int x = 1;
            int y = 1;
            Road road = new Road(x, y);
            //Image testImage = road.roadImg;// ����������� ���������� ��� ���� ����� ��� ��������

            int expected = 790;// ������ ��������, ����� ��� ����
            int actual = road.Height; //������, ����� �� ����������

            Assert.AreEqual(expected, actual, "������ ���������� �� ��������� � ��������� �� �������");// ������� ������ ��������
        }
    }
}
