using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Galaga
{
    class Character : Object
    {
        Image[] AnimateImage;
        public double x { get; set; } //좌표계 모서리 기준 
        public double y { get; set; } //좌표계 모서리 기준 
        public double centerX { get; set; } // 캐릭터 중심좌표
        public double CenterY { get; set; } // 캐릭터 중심좌표
        public int left { get; set; }
        public int right { get; set; }
        public int top { get; set; }
        public int bottom { get; set; }
        public Character()
        { }
        public virtual void InitCahracter()
        { }
        public bool collisionCheck(Character anotherObject)
        {

            if (true) 
            { 
                return true; 
            }
            else
            {
                return false;
            }
            
        }
    }
    class enmey: Character
    {
        
    }
    class player : Character
    {
        
    }
    class bullet : Character
    {
        
    }
    class effact : Character
    {
        
    }
    enum CharcacterType
    {
        PLAYER,ENEMY, 
    }
}
