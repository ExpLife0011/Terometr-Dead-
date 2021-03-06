﻿using Detrav.TeraApi;
using Detrav.TeraApi.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPlugin
{
    public class Plugin : IPlugin
    {

        public static void register()
        {
            //System.Windows.MessageBox.Show("Registered!");
        }
        MainWindow w;
        public void load(ITeraConnection parent)
        {
            //System.Windows.MessageBox.Show("loaded");
            parent.onLogin += parent_onLogin;
            parent.onSpawnPlayer += parent_onSpawnPlayer;
            parent.onDeSpawnPlayer += parent_onDeSpawnPlayer;
            parent.onDamage += parent_onDamage;
            parent.onBattleStart += parent_onBattleStart;
            parent.onBattleEnd += parent_onBattleEnd;
            w = new MainWindow();
            show();
        }

        void parent_onBattleEnd(object sender, PlayerEventArgs e)
        {
            w.addText(String.Format("Кончил бой: {0}", e.player.name));
        }

        void parent_onBattleStart(object sender, PlayerEventArgs e)
        {
            w.addText(String.Format("Начал бой : {0}", e.player.name));
        }

        

        void parent_onDamage(object sender, DamageEventArgs e)
        {
            //w.addText(String.Format("Нанёс урон: {0,16} {1}", e.player.name, e.damage));
        }

        void parent_onDeSpawnPlayer(object sender, PlayerEventArgs e)
        {
            //w.addText(String.Format("Ушёл : {0}", e.player.name));
        }

        void parent_onSpawnPlayer(object sender, PlayerEventArgs e)
        {
            //w.addText(String.Format("Спавн: {0}", e.player.name));
        }

        void parent_onLogin(object sender, PlayerEventArgs e)
        {
            w.addText(String.Format("Это я: {0}", e.player.name));
        }

        public void show()
        {
            w.Show();
            //w.WindowState = System.Windows.WindowState.Normal;
        }

        public void unLoad()
        {
            w.close = true;
            w.Close();
        }


        public void hide()
        {
            w.Hide();
            //w.WindowState = System.Windows.WindowState.Minimized;
        }
    }
}
