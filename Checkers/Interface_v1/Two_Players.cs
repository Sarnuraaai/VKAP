/**
    @file Two_Players.cs
    @brief Файл игры Шашки
    @copyright VKAP
    @author Красильников В.Г. и Преснухин А.П.
    @date 27-12-2023
    @version 1.1.20
\par Использует класс:
    @ref Two_Players
\par Содержит класс:
    @ref Two_Players
*/
using Interface_v1.Properties;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Drawing.Design;
using System.Resources;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Interface_v1
{
    /**
    @brief Класс Two_Players
    
    Основной и единственный класс, отвечающий за работу игры
    */
    public partial class Two_Players : Form
    {
        const int mapSize = 8;
        const int cellSize = 45;

        int currentPlayer;

        List<Button> simpleSteps = new List<Button>();

        int countEatSteps = 0;
        Button? prevButton;
        Button pressedButton;

        bool isContinue = false;

        bool isMoving;

        int[,] map = new int[mapSize, mapSize];

        Button[,] buttons = new Button[mapSize, mapSize];

        Image whiteFigure;
        Image blackFigure;

        Image whiteKingFigure;
        Image blackKingFigure;

        Label white_label = new Label();
        Label black_label = new Label();

        int min = 10, sec = 01;

        PictureBox black_Model_1, black_Model_2, black_Model_3, black_Model_4, black_Model_5,
                   black_Model_6, black_Model_7, black_Model_8, black_Model_9, black_Model_10,
                   black_Model_11, black_Model_12;

        PictureBox white_Model_1, white_Model_2, white_Model_3, white_Model_4, white_Model_5,
                   white_Model_6, white_Model_7, white_Model_8, white_Model_9, white_Model_10,
                   white_Model_11, white_Model_12;

        int whitePoints = 0;
        int blackPoints = 0;

        /// Метод, присваивающий изображения шашкам и проводящий инициализацию
        /** Присваивает шашкам изображения и проводит инициализацию игры
        \param whiteFigure присвоение изображения белой шашки
        \param blackFigure присвоение изображения чёрной шашки
        \param whiteKingFigure присвоение изображения белой королевской шашки
        \param blackKingFigure присвоение изображения чёрной королевской шашки
        \param black_Model_1 присвоение имени, размера, позиции и изображения выбывших черных шашек
        \param black_Model_2 присвоение имени, размера, позиции и изображения выбывших черных шашек
        \param black_Model_3 присвоение имени, размера, позиции и изображения выбывших черных шашек
        \param black_Model_4 присвоение имени, размера, позиции и изображения выбывших черных шашек
        \param black_Model_5 присвоение имени, размера, позиции и изображения выбывших черных шашек
        \param black_Model_6 присвоение имени, размера, позиции и изображения выбывших черных шашек
        \param black_Model_7 присвоение имени, размера, позиции и изображения выбывших черных шашек
        \param black_Model_8 присвоение имени, размера, позиции и изображения выбывших черных шашек
        \param black_Model_9 присвоение имени, размера, позиции и изображения выбывших черных шашек
        \param black_Model_10 присвоение имени, размера, позиции и изображения выбывших черных шашек
        \param black_Model_11 присвоение имени, размера, позиции и изображения выбывших черных шашек
        \param black_Model_12 присвоение имени, размера, позиции и изображения выбывших черных шашек
        \param white_Model_1 присвоение имени, размера, позиции и изображения выбывших белых шашек
        \param white_Model_2 присвоение имени, размера, позиции и изображения выбывших белых шашек
        \param white_Model_3 присвоение имени, размера, позиции и изображения выбывших белых шашек
        \param white_Model_4 присвоение имени, размера, позиции и изображения выбывших белых шашек
        \param white_Model_5 присвоение имени, размера, позиции и изображения выбывших белых шашек
        \param white_Model_6 присвоение имени, размера, позиции и изображения выбывших белых шашек
        \param white_Model_7 присвоение имени, размера, позиции и изображения выбывших белых шашек
        \param white_Model_8 присвоение имени, размера, позиции и изображения выбывших белых шашек
        \param white_Model_9 присвоение имени, размера, позиции и изображения выбывших белых шашек
        \param white_Model_10 присвоение имени, размера, позиции и изображения выбывших белых шашек
        \param white_Model_11 присвоение имени, размера, позиции и изображения выбывших белых шашек
        \param white_Model_12 присвоение имени, размера, позиции и изображения выбывших белых шашек
        */
        public Two_Players()
        {
            InitializeComponent();

            whiteFigure = new Bitmap(Interface_v1.Properties.Resources.white, new Size(cellSize - 9, cellSize - 9));
            blackFigure = new Bitmap(Interface_v1.Properties.Resources.black, new Size(cellSize - 9, cellSize - 9));
            whiteKingFigure = new Bitmap(Interface_v1.Properties.Resources.whiteKing, new Size(cellSize - 9, cellSize - 9));
            blackKingFigure = new Bitmap(Interface_v1.Properties.Resources.blackKing, new Size(cellSize - 9, cellSize - 9));

            black_Model_1 = new PictureBox { Name = "Black_Model_1", Size = new Size(332, 49), Location = new Point(374, 17), Image = Interface_v1.Properties.Resources.Black_Model_1, BackColor = Color.Transparent }; 
            black_Model_2 = new PictureBox { Name = "Black_Model_2", Size = new Size(332, 49), Location = new Point(374, 17), Image = Interface_v1.Properties.Resources.Black_Model_2, BackColor = Color.Transparent }; 
            black_Model_3 = new PictureBox { Name = "Black_Model_3", Size = new Size(332, 49), Location = new Point(374, 17), Image = Interface_v1.Properties.Resources.Black_Model_3, BackColor = Color.Transparent }; 
            black_Model_4 = new PictureBox { Name = "Black_Model_4", Size = new Size(332, 49), Location = new Point(374, 17), Image = Interface_v1.Properties.Resources.Black_Model_4, BackColor = Color.Transparent }; 
            black_Model_5 = new PictureBox { Name = "Black_Model_5", Size = new Size(332, 49), Location = new Point(374, 17), Image = Interface_v1.Properties.Resources.Black_Model_5, BackColor = Color.Transparent }; 
            black_Model_6 = new PictureBox { Name = "Black_Model_6", Size = new Size(332, 49), Location = new Point(374, 17), Image = Interface_v1.Properties.Resources.Black_Model_6, BackColor = Color.Transparent }; 
            black_Model_7 = new PictureBox { Name = "Black_Model_7", Size = new Size(332, 49), Location = new Point(374, 17), Image = Interface_v1.Properties.Resources.Black_Model_7, BackColor = Color.Transparent }; 
            black_Model_8 = new PictureBox { Name = "Black_Model_8", Size = new Size(332, 49), Location = new Point(374, 17), Image = Interface_v1.Properties.Resources.Black_Model_8, BackColor = Color.Transparent }; 
            black_Model_9 = new PictureBox { Name = "Black_Model_9", Size = new Size(332, 49), Location = new Point(374, 17), Image = Interface_v1.Properties.Resources.Black_Model_9, BackColor = Color.Transparent };
            black_Model_10 = new PictureBox { Name = "Black_Model_10", Size = new Size(332, 49), Location = new Point(374, 17), Image = Interface_v1.Properties.Resources.Black_Model_10, BackColor = Color.Transparent };
            black_Model_11 = new PictureBox { Name = "Black_Model_11", Size = new Size(332, 49), Location = new Point(374, 17), Image = Interface_v1.Properties.Resources.Black_Model_11, BackColor = Color.Transparent };
            black_Model_12 = new PictureBox { Name = "Black_Model_12", Size = new Size(332, 49), Location = new Point(374, 17), Image = Interface_v1.Properties.Resources.Black_Model_12, BackColor = Color.Transparent };

            white_Model_1 = new PictureBox { Name = "White_Model_1", Size = new Size(332, 49), Location = new Point(374, 294), Image = Interface_v1.Properties.Resources.White_Model_1, BackColor = Color.Transparent }; 
            white_Model_2 = new PictureBox { Name = "White_Model_2", Size = new Size(332, 49), Location = new Point(374, 294), Image = Interface_v1.Properties.Resources.White_Model_2, BackColor = Color.Transparent }; 
            white_Model_3 = new PictureBox { Name = "White_Model_3", Size = new Size(332, 49), Location = new Point(374, 294), Image = Interface_v1.Properties.Resources.White_Model_3, BackColor = Color.Transparent }; 
            white_Model_4 = new PictureBox { Name = "White_Model_4", Size = new Size(332, 49), Location = new Point(374, 294), Image = Interface_v1.Properties.Resources.White_Model_4, BackColor = Color.Transparent }; 
            white_Model_5 = new PictureBox { Name = "White_Model_5", Size = new Size(332, 49), Location = new Point(374, 294), Image = Interface_v1.Properties.Resources.White_Model_5, BackColor = Color.Transparent }; 
            white_Model_6 = new PictureBox { Name = "White_Model_6", Size = new Size(332, 49), Location = new Point(374, 294), Image = Interface_v1.Properties.Resources.White_Model_6, BackColor = Color.Transparent }; 
            white_Model_7 = new PictureBox { Name = "White_Model_7", Size = new Size(332, 49), Location = new Point(374, 294), Image = Interface_v1.Properties.Resources.White_Model_7, BackColor = Color.Transparent }; 
            white_Model_8 = new PictureBox { Name = "White_Model_8", Size = new Size(332, 49), Location = new Point(374, 294), Image = Interface_v1.Properties.Resources.White_Model_8, BackColor = Color.Transparent }; 
            white_Model_9 = new PictureBox { Name = "White_Model_9", Size = new Size(332, 49), Location = new Point(374, 294), Image = Interface_v1.Properties.Resources.White_Model_9, BackColor = Color.Transparent }; 
            white_Model_10 = new PictureBox { Name = "White_Model_10", Size = new Size(332, 49), Location = new Point(374, 294), Image = Interface_v1.Properties.Resources.White_Model_10, BackColor = Color.Transparent };
            white_Model_11 = new PictureBox { Name = "White_Model_11", Size = new Size(332, 49), Location = new Point(374, 294), Image = Interface_v1.Properties.Resources.White_Model_11, BackColor = Color.Transparent };
            white_Model_12 = new PictureBox { Name = "White_Model_12", Size = new Size(332, 49), Location = new Point(374, 294), Image = Interface_v1.Properties.Resources.White_Model_12, BackColor = Color.Transparent };

            this.Text = "CHECKERS";

            Init();
        }

        /// Метод инициализации
        /** Инициализация всех компонентов игры
        @param currentPlayer Текущий игрок(1 или 2)
        @param isMoving Ход
        @param prevButton Кнопка, на которую перемещаемся
        @param map Массив карты, где 1 и 2 - это первый и второй игрок соответственно, а 0 - пустая клетка
        */
        public void Init()
        {
            currentPlayer = 1;
            isMoving = false;
            prevButton = null;

            map = new int[mapSize, mapSize] {
                { 0,1,0,1,0,1,0,1 },
                { 1,0,1,0,1,0,1,0 },
                { 0,1,0,1,0,1,0,1 },
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 },
                { 2,0,2,0,2,0,2,0 },
                { 0,2,0,2,0,2,0,2 },
                { 2,0,2,0,2,0,2,0 }
                };
            CreateMap();
        }

        /**
        @brief Метод сброса игры

        Перезапускает игру с начала
        @param player1 Игрок 1
        @param player2 Игрок 2
        */
        public void ResetGame()
        {
            bool player1 = false;
            bool player2 = false;

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (map[i, j] == 1)
                    {
                        player1 = true;
                    }
                    if (map[i, j] == 2)
                    {
                        player2 = true;
                    }
                }
            }
            if (!player1 || !player2)
            {
                this.Controls.Clear();
                Init();
            }
            if (player1 || player2)
            {
                this.Controls.Clear();
                Init();
            }
        }
        /**
        @brief Метод создания карты

        Создаёт игровую карту(поле)
        @param Wifth Ширина
        @param Height Высота
        */
        public void CreateMap()
        {
            this.BackgroundImage = Interface_v1.Properties.Resources.Background_Interface;

            this.Width = (int)((mapSize + 8.37) * cellSize);
            this.Height = (int)((mapSize + 0.88) * cellSize);

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    Button button = new Button();
                    button.Location = new Point(j * cellSize, i * cellSize);
                    button.Size = new Size(cellSize, cellSize);
                    button.Click += new EventHandler(OnFigurePress);
                    button.ImageAlign = ContentAlignment.MiddleRight;
                    button.FlatAppearance.BorderSize = 0;
                    button.FlatStyle = FlatStyle.Flat;
                    button.Cursor = Cursors.Hand;

                    if (map[i, j] == 1)
                    {
                        button.Image = whiteFigure;
                    }
                    else if (map[i, j] == 2)
                    {
                        button.Image = blackFigure;
                    }

                    button.BackColor = GetPrevButtonColor(button);
                    button.ForeColor = Color.Gray;

                    buttons[i, j] = button;

                    this.Controls.Add(button);
                    this.Controls.Add(ResetButton);
                    this.Controls.Add(UndoButton);

                    CalculatePoints();
                    whitePoints = 0;
                    blackPoints = 0;

                    white_label.Location = new Point(400, 148);
                    white_label.Text = "БЕЛЫЕ";
                    white_label.ForeColor = Color.White;
                    white_label.Visible = true;
                    white_label.BackColor = Color.Transparent;
                    white_label.AutoSize = true;
                    white_label.TextAlign = ContentAlignment.MiddleCenter;
                    white_label.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
                    this.Controls.Add(white_label);

                    black_label.Location = new Point(385, 148);
                    black_label.Text = "ЧЁРНЫЕ";
                    black_label.ForeColor = Color.Black;
                    black_label.Visible = false;
                    black_label.BackColor = Color.Transparent;
                    black_label.AutoSize = true;
                    black_label.TextAlign = ContentAlignment.MiddleCenter;
                    black_label.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
                    this.Controls.Add(black_label);

                    timer.Start();
                    this.Controls.Add(Time);

                    black_Model_1.Visible = false; this.Controls.Add(black_Model_1);
                    black_Model_2.Visible = false; this.Controls.Add(black_Model_2);
                    black_Model_3.Visible = false; this.Controls.Add(black_Model_3);
                    black_Model_4.Visible = false; this.Controls.Add(black_Model_4);
                    black_Model_5.Visible = false; this.Controls.Add(black_Model_5);
                    black_Model_6.Visible = false; this.Controls.Add(black_Model_6);
                    black_Model_7.Visible = false; this.Controls.Add(black_Model_7);
                    black_Model_8.Visible = false; this.Controls.Add(black_Model_8);
                    black_Model_9.Visible = false; this.Controls.Add(black_Model_9);
                    black_Model_10.Visible = false; this.Controls.Add(black_Model_10);
                    black_Model_11.Visible = false; this.Controls.Add(black_Model_11);
                    black_Model_12.Visible = false; this.Controls.Add(black_Model_12);

                    white_Model_1.Visible = false; this.Controls.Add(white_Model_1);
                    white_Model_2.Visible = false; this.Controls.Add(white_Model_2);
                    white_Model_3.Visible = false; this.Controls.Add(white_Model_3);
                    white_Model_4.Visible = false; this.Controls.Add(white_Model_4);
                    white_Model_5.Visible = false; this.Controls.Add(white_Model_5);
                    white_Model_6.Visible = false; this.Controls.Add(white_Model_6);
                    white_Model_7.Visible = false; this.Controls.Add(white_Model_7);
                    white_Model_8.Visible = false; this.Controls.Add(white_Model_8);
                    white_Model_9.Visible = false; this.Controls.Add(white_Model_9);
                    white_Model_10.Visible = false; this.Controls.Add(white_Model_10);
                    white_Model_11.Visible = false; this.Controls.Add(white_Model_11);
                    white_Model_12.Visible = false; this.Controls.Add(white_Model_12);
                }
            }
        }

        /**
        @brief Метод смены игрково

        Осуществялет передачу хода от одного игрока к другому
        */
        public void SwitchPlayer()
        {
            currentPlayer = currentPlayer == 1 ? 2 : 1;

            if (currentPlayer == 2)
            {
                black_label.Visible = true;
                white_label.Visible = false;
                black_label.ForeColor = Color.Black;
            }
            else
            {
                white_label.Visible = true;
                black_label.Visible = false;
                white_label.ForeColor = Color.White;
            }

        }

        /**
        @brief Метод получения цвета

        Возвращает цвет кнопок, возможных для хода
        */
        public Color GetPrevButtonColor(Button prevButton)
        {
            if ((prevButton.Location.Y / cellSize % 2) != 0)
            {
                if ((prevButton.Location.X / cellSize % 2) == 0)
                {
                    return Color.Black;
                }
            }
            if ((prevButton.Location.Y / cellSize) % 2 == 0)
            {
                if ((prevButton.Location.X / cellSize) % 2 != 0)
                {
                    return Color.Black;
                }
            }
            return Color.White;
        }

        /**
        @brief Метод

        Производит операции с нажатой кнопкой
        */
        public void OnFigurePress(object sender, EventArgs e)
        {
            if (prevButton != null)
            {
                prevButton.BackColor = GetPrevButtonColor(prevButton);
            }

            pressedButton = (Button)sender;

            if (map[pressedButton.Location.Y / cellSize, pressedButton.Location.X / cellSize] != 0 && map[pressedButton.Location.Y / cellSize, pressedButton.Location.X / cellSize] == currentPlayer)
            {
                CloseSteps();
                pressedButton.BackColor = Color.DarkGray;
                DeactivateAllButtons();
                pressedButton.Enabled = true;
                countEatSteps = 0;
                if (pressedButton.Image == whiteKingFigure || pressedButton.Image == blackKingFigure)
                {
                    ShowSteps(pressedButton.Location.Y / cellSize, pressedButton.Location.X / cellSize, false);
                }
                else
                {
                    ShowSteps(pressedButton.Location.Y / cellSize, pressedButton.Location.X / cellSize);
                }

                if (isMoving)
                {
                    CloseSteps();
                    pressedButton.BackColor = GetPrevButtonColor(pressedButton);
                    ShowPossibleSteps();
                    isMoving = false;
                }
                else
                {
                    isMoving = true;
                }
            }
            else
            {
                if (isMoving)
                {
                    isContinue = false;
                    if (Math.Abs(pressedButton.Location.X / cellSize - prevButton.Location.X / cellSize) > 1)
                    {
                        isContinue = true;
                        DeleteEaten(pressedButton, prevButton);
                    }
                    int temp = map[pressedButton.Location.Y / cellSize, pressedButton.Location.X / cellSize];
                    map[pressedButton.Location.Y / cellSize, pressedButton.Location.X / cellSize] = map[prevButton.Location.Y / cellSize, prevButton.Location.X / cellSize];
                    map[prevButton.Location.Y / cellSize, prevButton.Location.X / cellSize] = temp;
                    pressedButton.Image = prevButton.Image;
                    prevButton.Image = null;
                    pressedButton.Text = prevButton.Text;
                    prevButton.Text = "";
                    SwitchButtonToCheat(pressedButton);
                    countEatSteps = 0;
                    isMoving = false;
                    CloseSteps();
                    DeactivateAllButtons();
                    if (pressedButton.Image == whiteKingFigure || pressedButton.Image == blackKingFigure)
                    {
                        ShowSteps(pressedButton.Location.Y / cellSize, pressedButton.Location.X / cellSize, false);
                    }
                    else
                    {
                        ShowSteps(pressedButton.Location.Y / cellSize, pressedButton.Location.X / cellSize);
                    }
                    if (countEatSteps == 0 || !isContinue)
                    {
                        CloseSteps();
                        SwitchPlayer();
                        ShowPossibleSteps();
                        isContinue = false;
                    }
                    else if (isContinue)
                    {
                        pressedButton.BackColor = Color.Gray;
                        pressedButton.Enabled = true;
                        isMoving = true;
                    }
                }
            }
            prevButton = pressedButton;

        }

        /**
        @brief Метод показа шагов

        Отображает возможные ходы для выбранной фигуры
        @param isOneStep Проверка на ход
        @param isEatStep Проверка на возможность съесть
        */
        public void ShowPossibleSteps()
        {
            bool isOneStep = true;
            bool isEatStep = false;
            DeactivateAllButtons();
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (map[i, j] == currentPlayer)
                    {
                        if (buttons[i, j].Image == whiteKingFigure || buttons[i, j].Image == blackKingFigure)
                        {
                            isOneStep = false;
                        }
                        else
                        {
                            isOneStep = true;
                        }
                        if (IsButtonHasEatStep(i, j, isOneStep, new int[2] { 0, 0 }))
                        {
                            isEatStep = true;
                            buttons[i, j].Enabled = true;
                        }
                    }
                }
            }
            if (!isEatStep)
            {
                ActivateAllButtons();
            }

        }

        /**
        @brief Метод дамки

        Осуществяет переход состояния из шашки в дамку
        */
        public void SwitchButtonToCheat(Button button)
        {
            if (map[button.Location.Y / cellSize, button.Location.X / cellSize] == 1 && button.Location.Y / cellSize == mapSize - 1)
            {
                button.Image = whiteKingFigure;
            }
            if (map[button.Location.Y / cellSize, button.Location.X / cellSize] == 2 && button.Location.Y / cellSize == 0)
            {
                button.Image = blackKingFigure;
            }
        }

        /**
        @brief Метод удаления

        Удаляет съеденную шашку
        */
        public void DeleteEaten(Button endButton, Button startButton)
        {
            int count = Math.Abs(endButton.Location.Y / cellSize - startButton.Location.Y / cellSize);
            int startIndexX = endButton.Location.Y / cellSize - startButton.Location.Y / cellSize;
            int startIndexY = endButton.Location.X / cellSize - startButton.Location.X / cellSize;
            startIndexX = startIndexX < 0 ? -1 : 1;
            startIndexY = startIndexY < 0 ? -1 : 1;
            int currCount = 0;
            int i = startButton.Location.Y / cellSize + startIndexX;
            int j = startButton.Location.X / cellSize + startIndexY;
            while (currCount < count - 1)
            {
                map[i, j] = 0;
                buttons[i, j].Image = null;
                buttons[i, j].Text = "";
                i += startIndexX;
                j += startIndexY;
                currCount++;
            }
            CalculatePoints();
        }

        /**
        @brief Метод подсчёта очков

        Подсчитывает количество очков для каждого игрока
        */
        private void CalculatePoints()
        {
            if (currentPlayer == 1) // Если текущий игрок - белые
            {
                whitePoints++; // Увеличиваем счетчик очков для белых на 1
                white_label.Text = "БЕЛЫЕ"; 
            }
            else  // Если текущий игрок - черные
            {
                blackPoints++; // Увеличиваем счетчик очков для черных на 1
                black_label.Text = "ЧЁРНЫЕ"; 
            }
            WhiteScoreImage();
            BlackScoreImage();
        }

        /**
        @brief Метод отображения очков белого

        Отображает количество очков игрока с белыми шашками
        @param whitePoints Количество очков
        */
        public void WhiteScoreImage()
        {
            if (whitePoints == 1)
            {
                black_Model_1.Visible = true;
            }
            else if (whitePoints == 2)
            {
                black_Model_1.Visible = false;
                black_Model_2.Visible = true;
            }
            else if (whitePoints == 3)
            {
                black_Model_2.Visible = false;
                black_Model_3.Visible = true;
            }
            else if (whitePoints == 4)
            {
                black_Model_3.Visible = false;
                black_Model_4.Visible = true;
            }
            else if (whitePoints == 5)
            {
                black_Model_4.Visible = false;
                black_Model_5.Visible = true;
            }
            else if (whitePoints == 6)
            {
                black_Model_5.Visible = false;
                black_Model_6.Visible = true;
            }
            else if (whitePoints == 7)
            {
                black_Model_6.Visible = false;
                black_Model_7.Visible = true;
            }
            else if (whitePoints == 8)
            {
                black_Model_7.Visible = false;
                black_Model_8.Visible = true;
            }
            else if (whitePoints == 9)
            {
                black_Model_8.Visible = false;
                black_Model_9.Visible = true;
            }
            else if (whitePoints == 10)
            {
                black_Model_9.Visible = false;
                black_Model_10.Visible = true;
            }
            else if (whitePoints == 11)
            {
                black_Model_10.Visible = false;
                black_Model_11.Visible = true;
            }
            else if (whitePoints == 12)
            {
                black_Model_11.Visible = false;
                black_Model_12.Visible = true;
                MessageBox.Show("White wins!");
            }
        }

        /**
        @brief Метод отображения очков чёрного

        Отображает количество очков игрока с чёрными фигурами
        @param blackPoints Количество очков
        */
        public void BlackScoreImage()
        {
            if (blackPoints == 1)
            {
                white_Model_1.Visible = true;
            }
            else if (blackPoints == 2)
            {
                white_Model_1.Visible = false;
                white_Model_2.Visible = true;
            }
            else if (blackPoints == 3)
            {
                white_Model_2.Visible = false;
                white_Model_3.Visible = true;
            }
            else if (blackPoints == 4)
            {
                white_Model_3.Visible = false;
                white_Model_4.Visible = true;
            }
            else if (blackPoints == 5)
            {
                white_Model_4.Visible = false;
                white_Model_5.Visible = true;
            }
            else if (blackPoints == 6)
            {
                white_Model_5.Visible = false;
                white_Model_6.Visible = true;
            }
            else if (blackPoints == 7)
            {
                white_Model_6.Visible = false;
                white_Model_7.Visible = true;
            }
            else if (blackPoints == 8)
            {
                white_Model_7.Visible = false;
                white_Model_8.Visible = true;
            }
            else if (blackPoints == 9)
            {
                white_Model_8.Visible = false;
                white_Model_9.Visible = true;
            }
            else if (blackPoints == 10)
            {
                white_Model_9.Visible = false;
                white_Model_10.Visible = true;
            }
            else if (blackPoints == 11)
            {
                white_Model_10.Visible = false;
                white_Model_11.Visible = true;
            }
            else if (blackPoints == 12)
            {
                white_Model_11.Visible = false;
                white_Model_12.Visible = true;
                MessageBox.Show("Black wins!");
            }
        }

        /**
        @brief Метод всех шагов

        Показывает все доступные шаги
        */
        public void ShowSteps(int iCurrFigure, int jCurrFigure, bool IsOnestep = true)
        {
            simpleSteps.Clear();
            ShowDiagonal(iCurrFigure, jCurrFigure, IsOnestep);
            if (countEatSteps > 0)
            {
                CloseSimpleSteps(simpleSteps);
            }
        }

        /**
        @brief Метод ближайших шагов

        Показывает возможные ходы для обычных шашек
        */
        public void ShowDiagonal(int IcurrFigure, int JcurrFigure, bool isOneStep = false)
        {
            int j = JcurrFigure + 1;
            for (int i = IcurrFigure - 1; i >= 0; i--)
            {
                if (currentPlayer == 1 && isOneStep && !isContinue)
                {
                    break;
                }
                if (IsInsideBorders(i, j))
                {
                    if (!DeterminePath(i, j))
                    {
                        break;
                    }
                }
                if (j < 7)
                {
                    j++;
                }
                else
                {
                    break;
                }
                if (isOneStep)
                {
                    break;
                }
            }

            j = JcurrFigure - 1;
            for (int i = IcurrFigure - 1; i >= 0; i--)
            {
                if (currentPlayer == 1 && isOneStep && !isContinue)
                {
                    break;
                }
                if (IsInsideBorders(i, j))
                {
                    if (!DeterminePath(i, j))
                    {
                        break;
                    }
                }
                if (j > 0)
                {
                    j--;
                }
                else
                {
                    break;
                }
                if (isOneStep)
                {
                    break;
                }
            }

            j = JcurrFigure - 1;
            for (int i = IcurrFigure + 1; i < 8; i++)
            {
                if (currentPlayer == 2 && isOneStep && !isContinue)
                {
                    break;
                }
                if (IsInsideBorders(i, j))
                {
                    if (!DeterminePath(i, j))
                    {
                        break;
                    }
                }
                if (j > 0)
                {
                    j--;
                }
                else
                {
                    break;
                }
                if (isOneStep)
                {
                    break;
                }
            }

            j = JcurrFigure + 1;
            for (int i = IcurrFigure + 1; i < 8; i++)
            {
                if (currentPlayer == 2 && isOneStep && !isContinue)
                {
                    break;
                }
                if (IsInsideBorders(i, j))
                {
                    if (!DeterminePath(i, j))
                    {
                        break;
                    }
                }
                if (j < 7)
                {
                    j++;
                }
                else
                {
                    break;
                }
                if (isOneStep)
                {
                    break;
                }
            }
        }

        /**
        brief Метод определения пути

        Определяет путь, куда можно сходить, и подсвечивает его зелёным цветом
        */
        public bool DeterminePath(int ti, int tj)
        {
            if (map[ti, tj] == 0 && !isContinue)
            {
                buttons[ti, tj].BackColor = Color.DarkGreen;
                buttons[ti, tj].Enabled = true;
                simpleSteps.Add(buttons[ti, tj]);
            }
            else
            {
                if (map[ti, tj] != currentPlayer)
                {
                    if (pressedButton.Image == whiteKingFigure || pressedButton.Image == blackKingFigure)
                    {
                        ShowProceduralEat(ti, tj, false);
                    }
                    else
                    {
                        ShowProceduralEat(ti, tj);
                    }
                }
                return false;
            }
            return true;
        }

        /**
        @brief Метод деактивации кнопок

        Скрывает и отключает кнопки
        */
        public void CloseSimpleSteps(List<Button> simpleSteps)
        {
            if (simpleSteps.Count > 0)
            {
                for (int i = 0; i < simpleSteps.Count; i++)
                {
                    simpleSteps[i].BackColor = GetPrevButtonColor(simpleSteps[i]);
                    simpleSteps[i].Enabled = false;
                }
            }
        }

        /**
        @brief Метод, показывающий возможность съесть шашку

        Подсвечивает клетки красным цветом, если можно съесть шашку
        */
        public void ShowProceduralEat(int i, int j, bool isOneStep = true)
        {
            int dirX = i - pressedButton.Location.Y / cellSize;
            int dirY = j - pressedButton.Location.X / cellSize;
            dirX = dirX < 0 ? -1 : 1;
            dirY = dirY < 0 ? -1 : 1;
            int i1 = i;
            int j1 = j;
            bool isEmpty = true;
            while (IsInsideBorders(i1, j1))
            {
                if (map[i1, j1] != 0 && map[i1, j1] != currentPlayer)
                {
                    isEmpty = false;
                    break;
                }
                i1 += dirX;
                j1 += dirY;

                if (isOneStep)
                {
                    break;
                }
            }
            if (isEmpty)
            {
                return;
            }

            List<Button> toClose = new List<Button>();
            bool closeSimple = false;
            int ik = i1 + dirX;
            int jk = j1 + dirY;
            while (IsInsideBorders(ik, jk))
            {
                if (map[ik, jk] == 0)
                {
                    if (IsButtonHasEatStep(ik, jk, isOneStep, new int[2] { dirX, dirY }))
                    {
                        closeSimple = true;
                    }
                    else
                    {
                        toClose.Add(buttons[ik, jk]);
                    }
                    buttons[ik, jk].BackColor = Color.DarkRed;
                    buttons[ik, jk].Enabled = true;
                    countEatSteps++;
                }
                else
                {
                    break;
                }
                if (isOneStep)
                {
                    break;
                }
                jk += dirY;
                ik += dirX;
            }
            if (closeSimple && toClose.Count > 0)
            {
                CloseSimpleSteps(toClose);
            }
        }

        /**
        @brief Метод шагов с едой

        Показывает ход, если есть возможность съесть
        */
        public bool IsButtonHasEatStep(int IcurrFigure, int JcurrFigure, bool isOneStep, int[] dir)
        {
            bool eatStep = false;
            int j = JcurrFigure + 1;
            for (int i = IcurrFigure - 1; i >= 0; i--)
            {
                if (currentPlayer == 1 && isOneStep && !isContinue)
                {
                    break;
                }
                if (dir[0] == 1 && dir[1] == -1 && !isOneStep)
                {
                    break;
                }
                if (IsInsideBorders(i, j))
                {
                    if (map[i, j] != 0 && map[i, j] != currentPlayer)
                    {
                        eatStep = true;
                        if (!IsInsideBorders(i - 1, j + 1))
                        {
                            eatStep = false;
                        }
                        else if (map[i - 1, j + 1] != 0)
                        {
                            eatStep = false;
                        }
                        else
                        {
                            return eatStep;
                        }
                    }
                }
                if (j < 7)
                {
                    j++;
                }
                else
                {
                    break;
                }
                if (isOneStep)
                {
                    break;
                }
            }

            j = JcurrFigure - 1;
            for (int i = IcurrFigure - 1; i >= 0; i--)
            {
                if (currentPlayer == 1 && isOneStep && !isContinue)
                {
                    break;
                }
                if (dir[0] == 1 && dir[1] == 1 && !isOneStep)
                {
                    break;
                }
                if (IsInsideBorders(i, j))
                {
                    if (map[i, j] != 0 && map[i, j] != currentPlayer)
                    {
                        eatStep = true;
                        if (!IsInsideBorders(i - 1, j - 1))
                        {
                            eatStep = false;
                        }
                        else if (map[i - 1, j - 1] != 0)
                        {
                            eatStep = false;
                        }
                        else
                        {
                            return eatStep;
                        }
                    }
                }
                if (j > 0)
                {
                    j--;
                }
                else
                {
                    break;
                }
                if (isOneStep)
                {
                    break;
                }
            }

            j = JcurrFigure - 1;
            for (int i = IcurrFigure + 1; i < 8; i++)
            {
                if (currentPlayer == 2 && isOneStep && !isContinue)
                {
                    break;
                }
                if (dir[0] == -1 && dir[1] == 1 && !isOneStep)
                {
                    break;
                }
                if (IsInsideBorders(i, j))
                {
                    if (map[i, j] != 0 && map[i, j] != currentPlayer)
                    {
                        eatStep = true;
                        if (!IsInsideBorders(i + 1, j - 1))
                        {
                            eatStep = false;
                        }
                        else if (map[i + 1, j - 1] != 0)
                        {
                            eatStep = false;
                        }
                        else
                        {
                            return eatStep;
                        }
                    }
                }
                if (j > 0)
                {
                    j--;
                }
                else
                {
                    break;
                }
                if (isOneStep)
                {
                    break;
                }
            }

            j = JcurrFigure + 1;
            for (int i = IcurrFigure + 1; i < 8; i++)
            {
                if (currentPlayer == 2 && isOneStep && !isContinue)
                {
                    break;
                }
                if (dir[0] == -1 && dir[1] == -1 && !isOneStep)
                {
                    break;
                }
                if (IsInsideBorders(i, j))
                {
                    if (map[i, j] != 0 && map[i, j] != currentPlayer)
                    {
                        eatStep = true;
                        if (!IsInsideBorders(i + 1, j + 1))
                        {
                            eatStep = false;
                        }
                        else if (map[i + 1, j + 1] != 0)
                        {
                            eatStep = false;
                        }
                        else
                        {
                            return eatStep;
                        }
                    }
                }
                if (j < 7)
                {
                    j++;
                }
                else
                {
                    break;
                }
                if (isOneStep)
                {
                    break;
                }
            }
            return eatStep;
        }

        /**
        @brief Метод прекращений хода

        Устанавливает стандартный цвет кнопок
        */
        public void CloseSteps()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    buttons[i, j].BackColor = GetPrevButtonColor(buttons[i, j]);
                }
            }
        }

        /**
        @brief Метод проверки на барьеры

        Проверяет, не выходит ли шашка за границы карты
        */
        public bool IsInsideBorders(int ti, int tj)
        {
            if (ti >= mapSize || tj >= mapSize || ti < 0 || tj < 0)
            {
                return false;
            }
            return true;
        }

        /**
        @brief Метод активации кнопок

        Активирует все кнопки
        */
        public void ActivateAllButtons()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    buttons[i, j].Enabled = true;
                }
            }
        }
        /**
        @brief Метод деактивации кнопок

        Деактивирует все кнопки
        */
        public void DeactivateAllButtons()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    buttons[i, j].Enabled = false;
                }
            }
        }

        /** 
        @brief Кнопка Reset
        
        Запускает методы сброса игры
        */
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetGame();
            ResetTimer();
        }

        /**
       @brief Метод нажатия на кнопку Undo

       При нажании перенаправляет на метод Undo
       */
        private void UndoButton_Click(object sender, EventArgs e)
        {
            Undo();
        }

        /**
        @brief Метод с таймером

        Запускает таймер игры
        */
        private void timer_Tick(object sender, EventArgs e)
        {
            sec = sec - 1;
            if (sec == -1)
            {
                min = min - 1;
                sec = 59;
            }
            if (min == -1)
            {
                min = 59;
            }
            if (min == 0 && sec == 0)
            {
                timer.Stop();
                MessageBox.Show("Игра окончена! Время вышло!");
            }
            Time.Text = Convert.ToString(min + ":" + sec);
        }

        /**
        @brief Метод сброса таймера

        Сбрасывает таймер
        */
        private void ResetTimer()
        {
            timer.Stop();
            this.Controls.Remove(Time);
            min = 10;
            sec = 01;
            this.Controls.Add(Time);
            timer.Start();
        }

        /**
        @brief Метод отмены хода
        
        Отменяет последний ход
        */
        public void Undo()
        {
            if (prevButton != null)
            {
                prevButton.BackColor = GetPrevButtonColor(prevButton);
            }

            if (pressedButton != null)
            {
                int row = pressedButton.Location.Y / cellSize;
                int col = pressedButton.Location.X / cellSize;

                int startPosX = col * cellSize;
                int startPosY = row * cellSize;
                pressedButton.Location = new Point(startPosX, startPosY);
                map[row, col] = currentPlayer;
                pressedButton.Image = GetFigureImage(currentPlayer);

                int prevRow = prevButton.Location.Y / cellSize;
                int prevCol = prevButton.Location.X / cellSize;
                map[prevRow, prevCol] = 0;
                prevButton.Image = null;
            }

            pressedButton = null;
            isMoving = false;
            isContinue = false;

        }

        /**
        @brief Метод, возвращающий изображение

        Возвращает изображение шашки текущего игрока
        */
        public Image GetFigureImage(int currentPlayer)
        {
            if (currentPlayer == 1)
            {
                return whiteFigure;
            }
            else if (currentPlayer == 2)
            {
                return blackFigure;
            }
            return null;
        }

        /**
        @brief Метод, показывающий "скрытый" интерфейс при закрытии формы

        Открывает скрытую форму Interface
        */
        private void Two_Players_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form Interface = Application.OpenForms[0];
            Interface.Show();
        }
    }
}