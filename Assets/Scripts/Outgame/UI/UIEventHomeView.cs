using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Outgame
{
    public class UIEventHomeView : UIStackableView
    {
        protected override void AwakeCall()
        {
            ViewId = ViewID.Event;
            _hasPopUI = true;
        }

        public override void Enter()
        {
            base.Enter();

            UIStatusBar.Show();

            Debug.Log(EventHelper.GetAllOpenedEvent());
            Debug.Log(EventHelper.IsEventGamePlayable(1));
        }

        public void GoHome()
        {
            UIManager.NextView(ViewID.Home);
        }

        public void GoEventQuest()
        {
            //Debug.Log("イベントクエストに移動");
            UIManager.NextView(ViewID.EventQuest);
        }

        public void GoRanking()
        {
            Debug.Log("ランキングへ移動");
            //UIManager.NextView(ViewID.QuestResult);
        }


        public void DialogTest()
        {
            UICommonDialog.OpenOKDialog("テスト", "テストダイアログですよ", Test);
        }

        void Test(int type)
        {
            Debug.Log("here");
        }
    }

}

