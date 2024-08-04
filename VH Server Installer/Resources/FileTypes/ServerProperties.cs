using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Tomlyn.Model;

namespace VH_Server_Installer.Resources.FileTypes
{
    internal class ServerProperties
    {
        [DataMember(Name = "allow-flight")]
        public bool allowFlight { get; set; } = false;

        [DataMember(Name = "allow-nether")]
        public bool allowNether { get; set; } = true;

        [DataMember(Name = "broadcast-console-to-ops")]
        public bool broadcastConsoleToOps { get; set; } = true;

        [DataMember(Name = "broadcast-rcon-to-ops")]
        public bool broadcastRconToOps { get; set; } = true;

        [DataMember(Name = (string)"difficulty")]
        public string difficulty { get; set; } = "normal";

        [DataMember(Name = "enable-command-block")]
        public bool enableCommandBlock { get; set; } = false;

        [DataMember(Name = "enable-jmx-monitoring")]
        public bool enableJmxMonitoring { get; set; } = false;

        [DataMember(Name = "enable-query")]
        public bool enableQuery { get; set; } = false;

        [DataMember(Name = "enable-rcon")]
        public bool enableRcon { get; set; } = false;

        [DataMember(Name = "enable-status")]
        public bool enableStatus { get; set; } = true;

        [DataMember(Name = "enforce-whitelist")]
        public bool enforceWhitelist { get; set; } = false;

        [DataMember(Name = "entity-broadcast-range-percentage")]
        public int entityBroadcastRangePercentage { get; set; } = 100;

        [DataMember(Name = "force-gamemode")]
        public bool forceGamemode { get; set; } = false;

        [DataMember(Name = "function-permission-level")]
        public int functionPermissionLevel { get; set; } = 2;

        [DataMember(Name = "gamemode")]
        public string gamemode { get; set; } = "survival";

        [DataMember(Name = "generate-structures")]
        public bool generateStructures { get; set; } = true;

        [DataMember(Name = "generator-settings")]
        public string generatorSettings { get; set; } = "{}";

        [DataMember(Name = "hardcore")]
        public bool hardcore { get; set; } = false;

        [DataMember(Name = "hide-online-players")]
        public bool hideOnlinePlayers { get; set; } = false;

        [DataMember(Name = "level-name")]
        public string levelName { get; set; } = "world";

        [DataMember(Name = "level-seed")]
        public string levelSeed { get; set; } = "";

        [DataMember(Name = "level-type")]
        public string levelType { get; set; } = "minecraft:normal";

        [DataMember(Name = "max-players")]
        public int maxPlayers { get; set; } = 20;

        [DataMember(Name = "max-tick-time")]
        public int maxTickTime { get; set; } = 60000;

        [DataMember(Name = "max-world-size")]
        public int maxWorldSize { get; set; } = 29999984;

        [DataMember(Name = "motd")]
        public string motd { get; set; } = "A Minecraft Server";

        [DataMember(Name = "network-compression-threshold")]
        public int networkCompressionThreshold { get; set; } = 256;

        [DataMember(Name = "online-mode")]
        public bool onlineMode { get; set; } = true;

        [DataMember(Name = "op-permission-level")]
        public int opPermissionLevel { get; set; } = 4;

        [DataMember(Name = "player-idle-timeout")]
        public int playerIdleTimeout { get; set; } = 0;

        [DataMember(Name = "prevent-proxy-connections")]
        public bool preventProxyConnections { get; set; } = false;

        [DataMember(Name = "pvp")]
        public bool pvp { get; set; } = true;

        [DataMember(Name = "query.port")]
        public int queryPort { get; set; } = 25565;

        [DataMember(Name = "rate-limit")]
        public int rateLimit { get; set; } = 0;

        [DataMember(Name = "rcon.password")]
        public string rconPassword { get; set; } = "";

        [DataMember(Name = "rcon.port")]
        public int rconPort { get; set; } = 25575;

        [DataMember(Name = "require-resource-pack")]
        public bool requireResourcePack { get; set; } = false;

        [DataMember(Name = "resource-pack")]
        public string resourcePack { get; set; } = "";

        [DataMember(Name = "resource-pack-prompt")]
        public string resourcePackPrompt { get; set; } = "";

        [DataMember(Name = "resource-pack-sha1")]
        public string resourcePackSha1 { get; set; } = "";

        [DataMember(Name = "server-ip")]
        public string serverIp { get; set; } = "";

        [DataMember(Name = "server-port")]
        public int serverPort { get; set; } = 25565;

        [DataMember(Name = "simulation-distance")]
        public int simulationDistance { get; set; } = 10;

        [DataMember(Name = "spawn-animals")]
        public bool spawnAnimals { get; set; } = true;

        [DataMember(Name = "spawn-monsters")]
        public bool spawnMonsters { get; set; } = true;

        [DataMember(Name = "spawn-npcs")]
        public bool spawnNpcs { get; set; } = true;

        [DataMember(Name = "spawn-protection")]
        public int spawnProtection { get; set; } = 16;

        [DataMember(Name = "sync-chunk-writes")]
        public bool syncChunkWrites { get; set; } = true;

        [DataMember(Name = "text-filtering-config")]
        public string textFilteringConfig { get; set; } = "";

        [DataMember(Name = "use-native-transport")]
        public bool useNativeTransport { get; set; } = true;

        [DataMember(Name = "view-distance")]
        public int viewDistance { get; set; } = 10;

        [DataMember(Name = "white-list")]
        public bool whiteList { get; set; } = false;


        public void parse(string file)
        {
            if (!File.Exists(file))
            {
                return;
            }
            string[] strings = File.ReadAllLines(file);
            foreach (string s in strings)
            {
                if (s.Contains('='))
                {
                    string[] pair = s.Split('=');
                    switch (pair[0])
                    {
                        case "allow-flight":
                            allowFlight = bool.Parse(pair[1]);
                            break;
                        case "allow-nether":
                            allowNether = bool.Parse(pair[1]);
                            break;
                        case "broadcast-console-to-ops":
                            broadcastConsoleToOps = bool.Parse(pair[1]);
                            break;
                        case "broadcast-rcon-to-ops":
                            broadcastRconToOps = bool.Parse(pair[1]);
                            break;
                        case "difficulty":
                            difficulty = pair[1];
                            break;
                        case "enable-command-block":
                            enableCommandBlock = bool.Parse(pair[1]);
                            break;
                        case "enable-jmx-monitoring":
                            enableJmxMonitoring = bool.Parse(pair[1]);
                            break;
                        case "enable-query":
                            enableQuery = bool.Parse(pair[1]);
                            break;
                        case "enable-rcon":
                            enableRcon = bool.Parse(pair[1]);
                            break;
                        case "enable-status":
                            enableStatus = bool.Parse(pair[1]);
                            break;
                        case "enforce-whitelist":
                            enforceWhitelist = bool.Parse(pair[1]);
                            break;
                        case "entity-broadcast-range-percentage":
                            entityBroadcastRangePercentage = int.Parse(pair[1]);
                            break;
                        case "force-gamemode":
                            forceGamemode = bool.Parse(pair[1]);
                            break;
                        case "function-permission-level":
                            functionPermissionLevel = int.Parse(pair[1]);
                            break;
                        case "gamemode":
                            gamemode = pair[1];
                            break;
                        case "generate-structures":
                            generateStructures = bool.Parse(pair[1]);
                            break;
                        case "generator-settings":
                            generatorSettings = pair[1];
                            break;
                        case "hardcore":
                            hardcore = bool.Parse(pair[1]);
                            break;
                        case "hide-online-players":
                            hideOnlinePlayers = bool.Parse(pair[1]);
                            break;
                        case "level-name":
                            levelName = pair[1];
                            break;
                        case "level-seed":
                            levelSeed = pair[1];
                            break;
                        case "level-type":
                            levelType = pair[1];
                            break;
                        case "max-players":
                            maxPlayers = int.Parse(pair[1]);
                            break;
                        case "max-tick-time":
                            maxTickTime = int.Parse(pair[1]);
                            break;
                        case "max-world-size":
                            maxWorldSize = int.Parse(pair[1]);
                            break;
                        case "motd":
                            motd = pair[1];
                            break;
                        case "network-compression-threshold":
                            networkCompressionThreshold = int.Parse(pair[1]);
                            break;
                        case "online-mode":
                            onlineMode = bool.Parse(pair[1]);
                            break;
                        case "op-permission-level":
                            opPermissionLevel = int.Parse(pair[1]);
                            break;
                        case "player-idle-timeout":
                            playerIdleTimeout = int.Parse(pair[1]);
                            break;
                        case "prevent-proxy-connections":
                            preventProxyConnections = bool.Parse(pair[1]);
                            break;
                        case "pvp":
                            pvp = bool.Parse(pair[1]);
                            break;
                        case "query.port":
                            queryPort = int.Parse(pair[1]);
                            break;
                        case "rate-limit":
                            rateLimit = int.Parse(pair[1]);
                            break;
                        case "rcon.password":
                            rconPassword = pair[1];
                            break;
                        case "rcon.port":
                            rconPort = int.Parse(pair[1]);
                            break;
                        case "require-resource-pack":
                            requireResourcePack = bool.Parse(pair[1]);
                            break;
                        case "resource-pack":
                            resourcePack = pair[1];
                            break;
                        case "resource-pack-prompt":
                            resourcePackPrompt = pair[1];
                            break;
                        case "resource-pack-sha1":
                            resourcePackSha1 = pair[1];
                            break;
                        case "server-ip":
                            serverIp = pair[1];
                            break;
                        case "server-port":
                            serverPort = int.Parse(pair[1]);
                            break;
                        case "simulation-distance":
                            simulationDistance = int.Parse(pair[1]);
                            break;
                        case "spawn-animals":
                            spawnAnimals = bool.Parse(pair[1]);
                            break;
                        case "spawn-monsters":
                            spawnMonsters = bool.Parse(pair[1]);
                            break;
                        case "spawn-npcs":
                            spawnNpcs = bool.Parse(pair[1]);
                            break;
                        case "spawn-protection":
                            spawnProtection = int.Parse(pair[1]);
                            break;
                        case "sync-chunk-writes":
                            syncChunkWrites = bool.Parse(pair[1]);
                            break;
                        case "text-filtering-config":
                            textFilteringConfig = pair[1];
                            break;
                        case "use-native-transport":
                            useNativeTransport = bool.Parse(pair[1]);
                            break;
                        case "view-distance":
                            viewDistance = int.Parse(pair[1]);
                            break;
                        case "white-list":
                            whiteList = bool.Parse(pair[1]);
                            break;
                    }
                }
                
            }
        }

        public void writeToFile(string file)
        {
            string content = "#Minecraft server properties" + Environment.NewLine + 
                "allow-flight=" + allowFlight.ToString().ToLower() + Environment.NewLine + 
                "allow-nether=" + allowNether.ToString().ToLower() + Environment.NewLine + 
                "broadcast-console-to-ops=" + broadcastConsoleToOps.ToString().ToLower() + Environment.NewLine + 
                "broadcast-rcon-to-ops=" + broadcastRconToOps.ToString().ToLower() + Environment.NewLine + 
                "difficulty=" + difficulty.ToString().ToLower() + Environment.NewLine +
                "enable-command-block=" + enableCommandBlock.ToString().ToLower() + Environment.NewLine +
                "enable-jmx-monitoring=" + enableJmxMonitoring.ToString().ToLower() + Environment.NewLine +
                "enable-query=" + enableQuery.ToString().ToLower() + Environment.NewLine +
                "enable-rcon=" + enableRcon.ToString().ToLower() + Environment.NewLine +
                "enable-status=" + enableStatus.ToString().ToLower() + Environment.NewLine +
                "enforce-whitelist=" + enforceWhitelist.ToString().ToLower() + Environment.NewLine +
                "entity-broadcast-range-percentage=" + entityBroadcastRangePercentage.ToString().ToLower() + Environment.NewLine +
                "force-gamemode=" + forceGamemode.ToString().ToLower() + Environment.NewLine +
                "function-permission-level=" + functionPermissionLevel.ToString().ToLower() + Environment.NewLine +
                "gamemode=" + gamemode.ToString().ToLower() + Environment.NewLine +
                "generate-structures=" + generateStructures.ToString().ToLower() + Environment.NewLine +
                "generator-settings=" + generatorSettings.ToString().ToLower() + Environment.NewLine +
                "hardcore=" + hardcore.ToString().ToLower() + Environment.NewLine +
                "hide-online-players=" + hideOnlinePlayers.ToString().ToLower() + Environment.NewLine +
                "level-name=" + levelName.ToString() + Environment.NewLine +
                "level-seed=" + levelSeed.ToString() + Environment.NewLine +
                "level-type=" + levelType.ToString().ToLower() + Environment.NewLine +
                "max-players=" + maxPlayers.ToString().ToLower() + Environment.NewLine +
                "max-tick-time=" + maxTickTime.ToString().ToLower() + Environment.NewLine +
                "max-world-size=" + maxWorldSize.ToString().ToLower() + Environment.NewLine +
                "motd=" + motd.ToString() + Environment.NewLine +
                "network-compression-threshold=" + networkCompressionThreshold.ToString().ToLower() + Environment.NewLine +
                "online-mode=" + onlineMode.ToString().ToLower() + Environment.NewLine +
                "op-permission-level=" + opPermissionLevel.ToString().ToLower() + Environment.NewLine +
                "player-idle-timeout=" + playerIdleTimeout.ToString().ToLower() + Environment.NewLine +
                "prevent-proxy-connections=" + preventProxyConnections.ToString().ToLower() + Environment.NewLine +
                "pvp=" + pvp.ToString().ToLower() + Environment.NewLine +
                "query.port=" + queryPort.ToString().ToLower() + Environment.NewLine +
                "rate-limit=" + rateLimit.ToString().ToLower() + Environment.NewLine +
                "rcon.password=" + rconPassword.ToString() + Environment.NewLine +
                "rcon.port=" + rconPort.ToString().ToLower() + Environment.NewLine +
                "require-resource-pack=" + requireResourcePack.ToString().ToLower() + Environment.NewLine +
                "resource-pack=" + resourcePack.ToString() + Environment.NewLine +
                "resource-pack-prompt=" + resourcePackPrompt.ToString() + Environment.NewLine +
                "resource-pack-sha1=" + resourcePackSha1.ToString() + Environment.NewLine +
                "server-ip=" + serverIp.ToString().ToLower() + Environment.NewLine +
                "server-port=" + serverPort.ToString().ToLower() + Environment.NewLine +
                "simulation-distance=" + simulationDistance.ToString().ToLower() + Environment.NewLine +
                "spawn-animals=" + spawnAnimals.ToString().ToLower() + Environment.NewLine +
                "spawn-monsters=" + spawnMonsters.ToString().ToLower() + Environment.NewLine +
                "spawn-npcs=" + spawnNpcs.ToString().ToLower() + Environment.NewLine +
                "spawn-protection=" + spawnProtection.ToString().ToLower() + Environment.NewLine +
                "sync-chunk-writes=" + syncChunkWrites.ToString().ToLower() + Environment.NewLine +
                "text-filtering-config=" + textFilteringConfig.ToString().ToLower() + Environment.NewLine +
                "use-native-transport=" + useNativeTransport.ToString().ToLower() + Environment.NewLine +
                "view-distance=" + viewDistance.ToString().ToLower() + Environment.NewLine +
                "white-list=" + whiteList.ToString().ToLower();
            File.WriteAllText(file, content);
        }
    }
}
