using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_334 : SimTemplate //* Hooded Acolyte
	{
		//Whenever a character is healed, give your C'Thun +1/+1 (wherever it is)
		
        public virtual void onAMinionGotHealedTrigger(Playfield p, Minion triggerEffectMinion, bool ownerOfMinionGotHealed)
        {
            p.anzOgOwnCThunHpBonus++;
            p.anzOgOwnCThunAngrBonus++;
        }

        public virtual void onAHeroGotHealedTrigger(Playfield p, Minion triggerEffectMinion, bool ownerOfHeroGotHealed)
        {
            p.anzOgOwnCThunHpBonus++;
            p.anzOgOwnCThunAngrBonus++;
        }
    }
}