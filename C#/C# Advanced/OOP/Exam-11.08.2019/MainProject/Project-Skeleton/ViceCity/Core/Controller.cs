using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViceCity.Core.Contracts;
using ViceCity.Models.Guns;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Neghbourhoods;
using ViceCity.Models.Neghbourhoods.Contracts;
using ViceCity.Models.Players;
using ViceCity.Models.Players.Contracts;

namespace ViceCity.Core
{
    public class Controller : IController
    {
        private IList<IPlayer> players;
        private IList<IGun> guns;
        private MainPlayer mainPlayer;
        private INeighbourhood neighbourhood;
        private bool somethingCanHappen = false;

        public Controller()
        {
            this.players = new List<IPlayer>();
            this.guns = new List<IGun>();
            this.mainPlayer = new MainPlayer();
            this.neighbourhood = new GangNeighbourhood();
        }

        public string AddGun(string type, string name)
        {
            if (type != "Pistol" && type != "Rifle")
            {
                return "Invalid gun type!";
            }

            if (type == "Pistol")
            {
                var gun = new Pistol(name);
                this.guns.Add(gun);
            }
            if (type == "Rifle")
            {
                var gun = new Rifle(name);
                this.guns.Add(gun);
            }

            return $"Successfully added {name} of type: {type}";
        }

        public string AddGunToPlayer(string name)
        {
            var gun = this.guns.FirstOrDefault();

            if (gun == null)
            {
                return "There are no guns in the queue!";
            }
            if (name == "Vercetti")
            {
                this.mainPlayer.GunRepository.Add(gun);
                somethingCanHappen = true;
                return $"Successfully added {gun.Name} to the Main Player: Tommy Vercetti";
            }
            if (this.players.Any(x => x.Name == name) == false)
            {
                return "Civil player with that name doesn't exists!";
            }

            somethingCanHappen = true;
            var player = this.players.FirstOrDefault(x => x.Name == name);
            player.GunRepository.Add(gun);

            return $"Successfully added {gun.Name} to the Civil Player: {name}";
        }

        public string AddPlayer(string name)
        {
            var player = new CivilPlayer(name);

            this.players.Add(player);

            return $"Successfully added civil player: {name}!";
        }

        public string Fight()
        {
            int civilPlayersCount = this.players.Count;

            neighbourhood.Action(this.mainPlayer, this.players);

            if (somethingCanHappen)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("A fight happened:");
                sb.AppendLine($"Tommy live points: {mainPlayer.LifePoints}!");
                int tommyKills = civilPlayersCount - this.players.Count;
                sb.AppendLine($"Tommy has killed: {tommyKills} players!");
                sb.AppendLine($"Left Civil Players: {this.players.Count}!");

                return sb.ToString().TrimEnd();
            }
            else
            {
                return "Everything is okay!";
            }
        }
    }
}
