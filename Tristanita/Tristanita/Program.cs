using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using System.Drawing;
namespace Tristanita
{
    internal class Program
    {
        //nombres
        public static string nombreChamp = "Tristana";
        public static Obj_AI_Hero jugador = ObjectManager.Player;
        public static float rango = 541 + 9 * jugador.Level;

        //Habilidades
        private static Spell Q, W, E, R;

        //Menu
        public static Menu menu;
        private static Orbwalking.Orbwalker Orb;

        public static void Main(string[] args)
        {
            //Registro de eventos
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }
        private static void Game_OnGameLoad(EventArgs args)
        {
            //Validar nombre campeon
            if (jugador.ChampionName != nombreChamp) return;
            //Definir spells
            
            Q = new Spell(SpellSlot.Q, rango);
            W = new Spell(SpellSlot.W, 1170f);
            W.SetSkillshot(0.5f, 270f, 1500f, false, SkillshotType.SkillshotCircle);
            E = new Spell(SpellSlot.E, rango);
            R = new Spell(SpellSlot.R, rango);

            //Menús
            menu = new Menu("Tristanita", nombreChamp, true);

            var ts = new Menu("Target Selector", "Target Selector");
            TargetSelector.AddToMenu(ts);
            menu.AddSubMenu(ts);

            menu.AddSubMenu(new Menu("Orbwalking", "Orbwalking"));

            Orb = new Orbwalking.Orbwalker(menu.SubMenu("Orbwalking"));

            menu.AddSubMenu(new Menu("Combo", "Combo"));
            menu.SubMenu("Combo").AddItem(new MenuItem("UsarQC", "Usar Q").SetValue(true));
            menu.SubMenu("Combo").AddItem(new MenuItem("UsarWC", "Usar W").SetValue(true));
            menu.SubMenu("Combo").AddItem(new MenuItem("UsarEC", "Usar E").SetValue(true));
            menu.SubMenu("Combo").AddItem(new MenuItem("UsarRC", "Usar R").SetValue(true));
            menu.SubMenu("Combo").AddItem(new MenuItem("ComboActivo", "Combo!").SetValue(new KeyBind(32, KeyBindType.Press)));

            menu.AddSubMenu(new Menu("Harass", "Harass"));
            menu.SubMenu("Harass").AddItem(new MenuItem("UsarEH", "Usar E").SetValue(true));
            menu.SubMenu("Harass").AddItem(new MenuItem("HarassActivo", "Harass").SetValue(new KeyBind(67, KeyBindType.Press)));
            
            
            Game.OnGameUpdate += Game_OnGameUpdate;
            menu.AddToMainMenu();
            Game.PrintChat("Hello Fiera!");

        }
        private static void Game_OnGameUpdate(EventArgs args)
        {

            Q.Range = rango;
            W.Range = 1170f;
            E.Range = rango;
            R.Range = rango;
            if (menu.Item("ComboActivo").GetValue<KeyBind>().Active)
            {
                Combo();
            }
            /*
            if(menu.Item("HarassActivo").GetValue<KeyBind>().Active)
            {
                Harass();
            }
             * */
        }
        private static void Combo()
        {
            var usarQ = menu.Item("UsarQC").GetValue<bool>();
            var usarW = menu.Item("UsarWC").GetValue<bool>();
            var usarE = menu.Item("UsarEC").GetValue<bool>();
            var usarR = menu.Item("UsarRC").GetValue<bool>();

            var tar = TargetSelector.GetTarget(Q.Range, TargetSelector.DamageType.Magical);

            if (tar == null)
            {
                return;
            }
            else
            {
                if (usarQ && Q.IsReady())
                {
                    Q.Cast();
                }
                if (usarE && E.IsReady())
                {
                    E.Cast(tar);
                }
                if (R.IsReady() && menu.Item("UsarRC").GetValue<bool>())
                {
                    foreach (var hero in ObjectManager.Get<Obj_AI_Hero>().Where(hero => hero.IsValidTarget(R.Range) && R.GetDamage(hero) > hero.Health))
                        R.Cast(hero);
                }
            }
        }
    }
}
