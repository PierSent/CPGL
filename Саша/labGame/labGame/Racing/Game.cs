using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Racing
{
    public partial class Game : Form
    {
        
        private RacingMenu menu;
        private Car car;
        private Coin coin;
        private Road road_1;
        private Road road_2;
        private Rock rock_1;
        private Rock rock_2;

        private int distRock = 700;
        private int magicNumber = 15; // погрешность
        private int velocity = 5;
        private int coinsInRound = 0;
        private int leftDistToRoad = 110;
        private int finalDist = 0;
        private int deltaY;
        private int allCoins;
        private int maxDist;
        private object[,] cars;

        public Game(int maxDist, int coins, object[,] cars)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            // объявление переменных
            this.maxDist = maxDist;
            this.allCoins = coins;
            this.cars = cars;
            InitializeComponent();
            road_1 = new Road(leftDistToRoad, 0);
            road_2 = new Road(leftDistToRoad, -Road.Height);
            createCar(cars);
            coin = new Coin(200, -distRock / 5);
            rock_1 = new Rock(300, 0);
            rock_2 = new Rock(150, -distRock / 2);

            timer.Interval = 5;
            timer.Tick += new EventHandler(update);
            timer.Start();

            this.KeyDown += Game_KeyDown;
            Invalidate();
        }

        private void createCar(object[,] cars) // создание машин
        {
            if ((bool)cars[0, 1])
            {
                car = new Car(216, 400, labGame.Properties.Resources.car);
            }
            if ((bool)cars[1, 1])
            {
                car = new Car(216, 400, labGame.Properties.Resources.carGreen);
            }
            if ((bool)cars[2, 1])
            {
                car = new Car(216, 400, labGame.Properties.Resources.carNeon);
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e) // нажатие клавиш   
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (car.Y > 0)
                    {
                        car.Y -= 5;
                    }
                    break;
                case Keys.Down:
                    if (car.Y < (this.Height - Car.Height - 2.5 * magicNumber))
                    {
                        car.Y += 5;
                    }
                    break;
                case Keys.Left:
                    if (car.X > (leftDistToRoad + magicNumber))
                    {
                        car.X -= 5;
                    }
                    break;
                case Keys.Right:
                    if (car.X <= (leftDistToRoad + Road.Width - Car.Width - magicNumber))
                    {
                        car.X += 5;
                    }
                    break;
            }      
        }

        private void update(object sender, EventArgs e) // обновление таймера   
        {
            if (isThisCross(car, rock_1) == true 
                || isThisCross(car, rock_2) == true)
            {
                timer.Stop();
                this.Hide();
                if (finalDist > maxDist)
                {
                    maxDist = finalDist;
                }
                allCoins += coinsInRound;
                menu = new RacingMenu(maxDist, allCoins, cars);
                menu.ShowDialog();
            }
            else
            {
                if (isThisCross(car, coin)){
                    coinsInRound++;
                    this.laCoinSum.Text = $"Coins: {coinsInRound}";
                }
                moreVelocity(finalDist);
                updateDelta(velocity);
                moveRoad();
                createRocks();
                moveRocks();
                createCoins();
                moveCoins();
                finalDist += velocity / 5;
                this.laFinalDist.Text = $"{finalDist} m";
            }
            Invalidate();
        }

        private void moreVelocity(int dist) // увеличение скорости   
        {
            if (finalDist > 1000)
            {
                velocity = 6;
            }
            if (finalDist > 2000)
            {
                velocity = 7;
            }
            if (finalDist > 3000)
            {
                velocity = 9;
            }
            if (finalDist > 5000)
            {
                velocity = 13;
            }
            if (finalDist > 10000)
            {
                velocity = 17;
            }
        }

        private bool isThisCross(Car car, Rock rock) // персечение машина/камень   
        {
            if ((car.Y <= (rock.Y + Rock.Height)) &&
                (car.Y + Car.Height) >= (rock.Y))
            {
                if ((car.X <= (rock.X + Rock.Width))
                    && ((car.X + Car.Width) >= (rock.X + Rock.Width)))
                {
                    return true;
                }
                else
                if (((car.X + Car.Width) >= rock.X) &&
                    (car.X <= rock.X))
                {
                    return true;
                }
            }
            return false;
        }
        
        private bool isThisCross(Car car, Coin coin) // персечение машина/монета   
        {
            if ((car.Y <= (coin.Y + Coin.Height)) &&
                (car.Y + Car.Height) >= (coin.Y))
            {
                if ((car.X <= (coin.X + Coin.Width))
                    && ((car.X + Car.Width) >= (coin.X + Coin.Width)))
                {
                    return true;
                }
                else
                if (((car.X + Car.Width) >= coin.X) &&
                    (car.X <= coin.X))
                {
                    return true;
                }
            }
            return false;
        }

        private bool isThisCross(Rock rock, Coin coin) // персечение камень/монета   
        {
            if ((rock.Y <= (coin.Y + Coin.Height)) &&
                (rock.Y + Car.Height) >= (coin.Y))
            {
                if ((rock.X <= (coin.X + Coin.Width))
                    && ((rock.X + Car.Width) >= (coin.X + Coin.Width)))
                {
                    return true;
                }
                else
                if (((rock.X + Car.Width) >= coin.X) &&
                    (rock.X <= coin.X))
                {
                    return true;
                }
            }
            return false;
        }

        private void createRocks() // сооздание камня   
        {
            if (rock_1.Y > distRock)
            {
                Random r = new Random();
                int randX = r.Next(leftDistToRoad, leftDistToRoad + Road.Width - Rock.Width);
                rock_1 = new Rock(randX, - Rock.Height);
            }
            if (rock_2.Y > distRock)
            {
                Random r = new Random();
                int randX = r.Next(leftDistToRoad, leftDistToRoad + Road.Width - Rock.Width);
                rock_2 = new Rock(randX, - Rock.Height);
            }
        }

        private void moveRocks() // движение камня  
        {
            rock_1.Y += velocity;
            rock_2.Y += velocity;
        }

        private void createCoins() // сооздание монетки   
        {
            if (coin.Y > distRock
                || (isThisCross(car, coin) == true))
            {
                Random r = new Random();
                int randX = r.Next(leftDistToRoad, leftDistToRoad + Road.Width - Coin.Width);
                coin = new Coin(randX, -Coin.Height);
                while (isThisCross(rock_1, coin)
                    || isThisCross(rock_2, coin))
                {
                    randX = r.Next(leftDistToRoad, leftDistToRoad + Road.Width - Coin.Width);
                    coin = new Coin(randX, -Coin.Height);
                }
            }
        }

        private void moveCoins() // движение монетки   
        {
            coin.Y += velocity;
        }
        
        private void moveRoad() // движение дороги (машины)   
        { 
            road_1.Y = deltaY;
            road_2.Y = deltaY + Road.Height;
        }

        private void updateDelta(int v) // дельта у дорог   
        {
            deltaY += v;
            if (deltaY > 0)
            {
                deltaY -= Road.Height;
            }
            else
            {
                if (deltaY < -Road.Height)
                {
                    deltaY += Road.Height;
                }
            }
        }

        private void OnPaint(object sender, PaintEventArgs e) // отрисовка графики   
        {
            Graphics g = e.Graphics;

            g.DrawImage(Road.roadImg, road_1.X, road_1.Y, Road.Width, Road.Height);
            g.DrawImage(Road.roadImg, road_2.X, road_2.Y, Road.Width, Road.Height);
            g.DrawImage(Rock.rockImg, rock_1.X, rock_1.Y, Rock.Width, Rock.Height);
            g.DrawImage(Rock.rockImg, rock_2.X, rock_2.Y, Rock.Width, Rock.Height);
            g.DrawImage(Coin.rockImg, coin.X, coin.Y, Coin.Width, Coin.Height);
            g.DrawImage(car.carImg, car.X, car.Y, Car.Width, Car.Height);
        }

        private void laFinalDist_Click(object sender, EventArgs e)
        {

        }
    }
}
