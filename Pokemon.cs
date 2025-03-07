using System;
using System.Drawing;
using System.IO; // เพิ่มสำหรับใช้ Path.Combine()

namespace PokemonDex
{
    public enum PokemonType
    {
        Normal,
        Flying,
        Electric,
        Fire,
        Fairy,
        Dragon,
        Ghost
    }

    public class Pokemon
    {
        // ข้อมูลพื้นฐานของ Pokémon
        protected string Name;
        protected int HP;
        protected int Attack;
        protected int Defense;
        protected int Speed;
        protected string Species;
        protected PokemonType Type;
        protected string ImagePath; // ใช้เก็บ Path ของรูปภาพ

        // Constructor (ตัวสร้าง)
        public Pokemon(string name, int hp, int attack, int defense, int speed, string species, PokemonType type, string imagePath)
        {
            this.Name = name;
            this.HP = hp;
            this.Attack = attack;
            this.Defense = defense;
            this.Speed = speed;
            this.Species = species;
            this.Type = type;
            this.ImagePath = imagePath;
        }

        // Getter สำหรับดึงข้อมูล
        public string GetName() { return this.Name; }
        public string GetSpecies() { return this.Species; }
        public int GetHP() { return this.HP; }
        public int GetAttack() { return this.Attack; }
        public int GetDefense() { return this.Defense; }
        public int GetSpeed() { return this.Speed; }
        public PokemonType GetPokemonType() { return this.Type; }

        // ✅ ปรับปรุงเมทอด GetImage() ให้ตรวจสอบไฟล์ก่อนโหลด
        public Image GetImage()
        {
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, this.ImagePath);

            if (File.Exists(fullPath))
            {
                return Image.FromFile(fullPath);
            }
            else
            {
                throw new FileNotFoundException("ไม่พบไฟล์รูปภาพ: " + fullPath);
            }
        }
    }
}
