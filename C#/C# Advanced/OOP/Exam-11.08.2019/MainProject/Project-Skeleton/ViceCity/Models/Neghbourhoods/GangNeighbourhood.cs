using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViceCity.Models.Neghbourhoods.Contracts;
using ViceCity.Models.Players.Contracts;

namespace ViceCity.Models.Neghbourhoods
{
    public class GangNeighbourhood : INeighbourhood
    {
        public void Action(IPlayer mainPlayer, ICollection<IPlayer> civilPlayers)
        {
            while (true)
            {
                if (civilPlayers.Count == 0 || mainPlayer.GunRepository.Models.Count == 0)
                {
                    break;
                }

                var gun = mainPlayer.GunRepository.Models.FirstOrDefault();
                
                if (gun == null)
                {
                    break;
                }

                var currentCP = civilPlayers.FirstOrDefault();

                if (currentCP == null)
                {
                    break;
                }

                currentCP.TakeLifePoints(gun.Fire());

                if (currentCP.IsAlive == false)
                {
                    civilPlayers.Remove(currentCP);
                    currentCP = civilPlayers.FirstOrDefault();
                    if (currentCP == null)
                    {
                        break;
                    }
                }
                if (gun.CanFire == false)
                {
                    mainPlayer.GunRepository.Remove(gun);
                    gun = mainPlayer.GunRepository.Models.FirstOrDefault();
                    if (gun == null)
                    {
                        break;
                    }
                }
            }
            
            if (civilPlayers.Count > 0)
            {
                while (true)
                {
                    if (civilPlayers.Count == 0 || mainPlayer.IsAlive == false)
                    {
                        break;
                    }

                    var currentCP = civilPlayers.FirstOrDefault();

                    var gun = currentCP.GunRepository.Models.FirstOrDefault();

                    if (gun.CanFire == false)
                    {
                        currentCP.GunRepository.Remove(gun);
                        gun = currentCP.GunRepository.Models.FirstOrDefault();
                        if (gun == null)
                        {
                            civilPlayers.Remove(currentCP);
                            currentCP = civilPlayers.FirstOrDefault();
                            if (currentCP == null)
                            {
                                break;
                            }
                        }
                    }

                    mainPlayer.TakeLifePoints(gun.Fire());
                }
            }
        }
    }
}
