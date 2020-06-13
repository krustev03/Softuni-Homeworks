using PlayersAndMonsters.Models.BattleFields.Contracts;
using PlayersAndMonsters.Models.Cards.Contracts;
using PlayersAndMonsters.Models.Players;
using PlayersAndMonsters.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayersAndMonsters.Models.BattleFields
{
    public class BattleField : IBattleField
    {
        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            if (attackPlayer.IsDead || enemyPlayer.IsDead)
            {
                throw new ArgumentException("Player is dead!");
            }

            if (attackPlayer is Beginner)
            {
                BoostBeginnerPlayer(attackPlayer);
            }
            if (enemyPlayer is Beginner)
            {
                BoostBeginnerPlayer(enemyPlayer);
            }

            BoostPlayer(attackPlayer);
            BoostPlayer(enemyPlayer);

            int attackPlayerDamage = attackPlayer.CardRepository
                .Cards
                .Sum(c => c.DamagePoints);

            int enemyPlayerDamage = enemyPlayer.CardRepository
                .Cards
                .Sum(c => c.DamagePoints);

            while (true)
            {
                enemyPlayer.TakeDamage(attackPlayerDamage);

                if (enemyPlayer.IsDead)
                {
                    break;
                }

                attackPlayer.TakeDamage(enemyPlayerDamage);

                if (attackPlayer.IsDead)
                {
                    break;
                }
            }
        }

        private void BoostBeginnerPlayer(IPlayer player)
        {
            player.Health += 40;

            foreach (ICard card in player.CardRepository.Cards)
            {
                card.DamagePoints += 30;
            }
        }

        private static void BoostPlayer(IPlayer player)
        {
            int playerBonusHealth = player.CardRepository
                .Cards
                .Sum(c => c.HealthPoints);

            player.Health += playerBonusHealth;
        }
    }
}
