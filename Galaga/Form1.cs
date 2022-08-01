using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galaga
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            PictureBox backGround = new PictureBox();
            initData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mainTimerTIck(object sender, EventArgs e)
        {
            upData();
            draw();
        }
        private void initData()
        {
            //좌표 정렬
            //  enmey-> 초기 좌표 , bullet초기좌표
            // ui 초기 좌표
            //캐릭터 초기좌표
        }
        private void draw()
        { 
            // background
            // player
            // enemy
            // bullet
        }
        private void upData()
        { 
            //euemy 움직임
            //플레이어 컨트롤 움직임
            //bullet 발사 움직임 
        }
        
    }
}
