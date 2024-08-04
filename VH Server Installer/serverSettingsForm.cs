using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tomlyn;
using VH_Server_Installer.Resources.FileTypes;

namespace VH_Server_Installer
{
    public partial class serverSettingsForm : Form
    {
        public serverSettingsForm(string _installPath)
        {
            InitializeComponent();
            installPath = _installPath;
        }
        private readonly string installPath;
        private ServerProperties sp = new ServerProperties();

        private void serverSettingsForm_Load(object sender, EventArgs e)
        {
            eulaCheckBox.Checked = eulaRead();
            serverPropertiesRead();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            eulaWrite(eulaCheckBox.Checked);
        }


        private string eulaString()
        {
            if (!File.Exists(installPath + "\\eula.txt")) 
            {
                return "eula=false";
            }
            return File.ReadAllText(installPath + "\\eula.txt");
        }

        private bool eulaRead()
        {
            Eula model = Toml.ToModel<Eula>(eulaString());
            return model.eula;
        }

        private void eulaWrite(bool eulaValue)
        {
            Eula model = Toml.ToModel<Eula>(eulaString());
            model.eula = eulaValue;
            File.WriteAllText(installPath + "\\eula.txt", Toml.FromModel(model));
        }

        private string serverPropertiesString()
        {
            return File.ReadAllText(installPath + "\\server.properties");
        }

        private void serverPropertiesRead()
        {
            sp.parse(installPath + "\\server.properties");
            allowFlightCheckBox.Checked = sp.allowFlight;
            allowNetherCheckBox.Checked = sp.allowNether;
            broadcastConsoleToOpsCheckBox.Checked = sp.broadcastConsoleToOps;
            broadcastRconToOpsCheckBox.Checked = sp.broadcastRconToOps;
            difficultyComboBox.Text = sp.difficulty;
            enableCommandBlockCheckBox.Checked = sp.enableCommandBlock;
            enableJmxMonitoringCheckBox.Checked = sp.enableJmxMonitoring;
            enableQueryCheckBox.Checked = sp.enableQuery;
            enableRconCheckBox.Checked = sp.enableRcon;
            enableStatusCheckBox.Checked = sp.enableStatus;
            enforceWhitelistCheckBox.Checked = sp.enforceWhitelist;
            entityBroadcastRangePercentageNumericUpDown.Value = sp.entityBroadcastRangePercentage;
            forceGamemodeCheckBox.Checked = sp.forceGamemode;
            functionPermissionLevelNumericUpDown.Value = sp.functionPermissionLevel;
            gamemodeComboBox.Text = sp.gamemode;
            generateStructuresCheckBox.Checked = sp.generateStructures;
            hardcoreCheckBox.Checked = sp.hardcore;
            hideOnlinePlayersCheckBox.Checked = sp.hideOnlinePlayers;
            levelNameTextBox.Text = sp.levelName;
            levelSeedTextBox.Text = sp.levelSeed;
            levelTypeComboBox.Text = sp.levelType;
            maxPlayersNumericUpDown.Value = sp.maxPlayers;
            maxTickTimeNumericUpDown.Value = sp.maxTickTime;
            maxWorldSizeNumericUpDown.Value = sp.maxWorldSize;
            motdTextBox.Text = sp.motd;
            networkCompressionThresholdNumericUpDown.Value = sp.networkCompressionThreshold;
            onlineModeCheckBox.Checked = sp.onlineMode;
            opPermissionLevelNumericUpDown.Value = sp.opPermissionLevel;
            playerIdleTimeoutNumericUpDown.Value = sp.playerIdleTimeout;
            preventProxyConnectionsCheckBox.Checked = sp.preventProxyConnections;
            pvpCheckBox.Enabled = sp.pvp;
            queryPortNumericUpDown.Value = sp.queryPort;
            rateLimitNumericUpDown.Value = sp.rateLimit;
            rconPasswordTextBox.Text = sp.rconPassword;
            rconPortNumericUpDown.Value = sp.rconPort;
            requireResourcePackCheckBox.Checked = sp.requireResourcePack;
            resourcePackTextBox.Text = sp.resourcePack;
            resourcePackPromptTextBox.Text = sp.resourcePackPrompt;
            resourcePackSha1TextBox.Text = sp.resourcePackSha1;
            serverIpTextBox.Text = sp.serverIp;
            serverPortNumericUpDown.Value = sp.serverPort;
            simulationDistanceNumericUpDown.Value = sp.simulationDistance;
            spawnAnimalsCheckBox.Checked = sp.spawnAnimals;
            spawnMonstersCheckBox.Checked = sp.spawnMonsters;
            spawnNpcsCheckBox.Checked = sp.spawnNpcs;
            spawnProtectionNumericUpDown.Value = sp.spawnProtection;
            syncChunkWritesCheckBox.Checked = sp.syncChunkWrites;
            textFilteringConfigTextBox.Text = sp.textFilteringConfig;
            useNativeTransportCheckBox.Checked = sp.useNativeTransport;
            viewDistanceNumericUpDown.Value = sp.viewDistance;
            whiteListCheckBox.Checked = sp.whiteList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            save();
            sp.writeToFile(installPath + "\\server.properties");
            MessageBox.Show("Server Propperties Saved", "Done");
        }

        private void save()
        {
            sp.allowFlight = allowFlightCheckBox.Checked;
            sp.allowNether = allowNetherCheckBox.Checked;
            sp.broadcastConsoleToOps = broadcastConsoleToOpsCheckBox.Checked;
            sp.broadcastRconToOps = broadcastRconToOpsCheckBox.Checked;
            sp.difficulty = difficultyComboBox.Text;
            sp.enableCommandBlock = enableCommandBlockCheckBox.Checked;
            sp.enableJmxMonitoring = enableJmxMonitoringCheckBox.Checked;
            sp.enableQuery = enableQueryCheckBox.Checked;
            sp.enableRcon = enableRconCheckBox.Checked;
            sp.enableStatus = enableStatusCheckBox.Checked;
            sp.enforceWhitelist = enforceWhitelistCheckBox.Checked;
            sp.entityBroadcastRangePercentage = (int)entityBroadcastRangePercentageNumericUpDown.Value;
            sp.forceGamemode = forceGamemodeCheckBox.Checked;
            sp.functionPermissionLevel = (int)functionPermissionLevelNumericUpDown.Value;
            sp.gamemode = gamemodeComboBox.Text;
            sp.generateStructures = generateStructuresCheckBox.Checked;
            sp.hardcore = hardcoreCheckBox.Checked;
            sp.hideOnlinePlayers = hideOnlinePlayersCheckBox.Checked;
            sp.levelName = levelNameTextBox.Text;
            sp.levelSeed = levelSeedTextBox.Text;
            sp.levelType = levelTypeComboBox.Text;
            sp.maxPlayers = (int)maxPlayersNumericUpDown.Value;
            sp.maxTickTime = (int)maxPlayersNumericUpDown.Value; 
            sp.maxWorldSize = (int)maxWorldSizeNumericUpDown.Value;
            sp.motd = motdTextBox.Text;
            sp.networkCompressionThreshold = (int)networkCompressionThresholdNumericUpDown.Value;
            sp.onlineMode = onlineModeCheckBox.Checked;
            sp.opPermissionLevel = (int)opPermissionLevelNumericUpDown.Value;
            sp.playerIdleTimeout = (int)playerIdleTimeoutNumericUpDown.Value;
            sp.preventProxyConnections = preventProxyConnectionsCheckBox.Checked;
            sp.pvp = pvpCheckBox.Checked;
            sp.queryPort = (int)queryPortNumericUpDown.Value;
            sp.rateLimit = (int)rateLimitNumericUpDown.Value;
            sp.rconPassword = rconPasswordTextBox.Text;
            sp.rconPort = (int)rconPortNumericUpDown.Value;
            sp.requireResourcePack = requireResourcePackCheckBox.Checked;
            sp.resourcePack = resourcePackTextBox.Text;
            sp.resourcePackPrompt = resourcePackPromptTextBox.Text;
            sp.resourcePackSha1 = resourcePackSha1TextBox.Text;
            sp.serverIp = serverIpTextBox.Text;
            sp.serverPort = (int)serverPortNumericUpDown.Value;
            sp.simulationDistance = (int)simulationDistanceNumericUpDown.Value;
            sp.spawnAnimals = spawnAnimalsCheckBox.Checked;
            sp.spawnMonsters = spawnMonstersCheckBox.Checked;
            sp.spawnNpcs = spawnNpcsCheckBox.Checked;
            sp.spawnProtection = (int)spawnProtectionNumericUpDown.Value;
            sp.syncChunkWrites = syncChunkWritesCheckBox.Checked;
            //sp.textFilteringConfig = textFilteringConfigTextBox.Text;
            sp.useNativeTransport = useNativeTransportCheckBox.Checked;
            sp.viewDistance = (int)viewDistanceNumericUpDown.Value;
            sp.whiteList = whiteListCheckBox.Checked;

        }

    }
}
