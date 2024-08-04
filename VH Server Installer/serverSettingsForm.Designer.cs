namespace VH_Server_Installer
{
    partial class serverSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            eulaCheckBox = new CheckBox();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            allowFlightCheckBox = new CheckBox();
            label27 = new Label();
            allowNetherCheckBox = new CheckBox();
            label26 = new Label();
            broadcastConsoleToOpsCheckBox = new CheckBox();
            whiteListCheckBox = new CheckBox();
            broadcastRconToOpsCheckBox = new CheckBox();
            label25 = new Label();
            difficultyComboBox = new ComboBox();
            viewDistanceNumericUpDown = new NumericUpDown();
            label1 = new Label();
            useNativeTransportCheckBox = new CheckBox();
            enableCommandBlockCheckBox = new CheckBox();
            textFilteringConfigTextBox = new TextBox();
            enableJmxMonitoringCheckBox = new CheckBox();
            syncChunkWritesCheckBox = new CheckBox();
            enableQueryCheckBox = new CheckBox();
            spawnProtectionNumericUpDown = new NumericUpDown();
            enableRconCheckBox = new CheckBox();
            spawnNpcsCheckBox = new CheckBox();
            enableStatusCheckBox = new CheckBox();
            spawnMonstersCheckBox = new CheckBox();
            enforceWhitelistCheckBox = new CheckBox();
            spawnAnimalsCheckBox = new CheckBox();
            entityBroadcastRangePercentageNumericUpDown = new NumericUpDown();
            snooperEnabledCheckBox = new CheckBox();
            label2 = new Label();
            label24 = new Label();
            forceGamemodeCheckBox = new CheckBox();
            simulationDistanceNumericUpDown = new NumericUpDown();
            functionPermissionLevelNumericUpDown = new NumericUpDown();
            label23 = new Label();
            label3 = new Label();
            serverPortNumericUpDown = new NumericUpDown();
            gamemodeComboBox = new ComboBox();
            label22 = new Label();
            label4 = new Label();
            serverIpTextBox = new TextBox();
            generateStructuresCheckBox = new CheckBox();
            label21 = new Label();
            generatorSettingTextBox = new TextBox();
            resourcePackSha1TextBox = new TextBox();
            label5 = new Label();
            label20 = new Label();
            hardcoreCheckBox = new CheckBox();
            resourcePackPromptTextBox = new TextBox();
            hideOnlinePlayersCheckBox = new CheckBox();
            label19 = new Label();
            levelNameTextBox = new TextBox();
            resourcePackTextBox = new TextBox();
            label6 = new Label();
            requireResourcePackCheckBox = new CheckBox();
            levelSeedTextBox = new TextBox();
            label18 = new Label();
            label7 = new Label();
            rconPortNumericUpDown = new NumericUpDown();
            levelTypeComboBox = new ComboBox();
            label17 = new Label();
            label8 = new Label();
            rconPasswordTextBox = new TextBox();
            maxPlayersNumericUpDown = new NumericUpDown();
            label16 = new Label();
            label9 = new Label();
            rateLimitNumericUpDown = new NumericUpDown();
            maxTickTimeNumericUpDown = new NumericUpDown();
            label15 = new Label();
            label10 = new Label();
            queryPortNumericUpDown = new NumericUpDown();
            maxWorldSizeNumericUpDown = new NumericUpDown();
            pvpCheckBox = new CheckBox();
            label11 = new Label();
            preventProxyConnectionsCheckBox = new CheckBox();
            motdTextBox = new TextBox();
            label14 = new Label();
            motd = new Label();
            playerIdleTimeoutNumericUpDown = new NumericUpDown();
            networkCompressionThresholdNumericUpDown = new NumericUpDown();
            label13 = new Label();
            onlineModeCheckBox = new CheckBox();
            label12 = new Label();
            opPermissionLevelNumericUpDown = new NumericUpDown();
            groupBox2 = new GroupBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewDistanceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spawnProtectionNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)entityBroadcastRangePercentageNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)simulationDistanceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)functionPermissionLevelNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serverPortNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rconPortNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxPlayersNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rateLimitNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxTickTimeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)queryPortNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxWorldSizeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerIdleTimeoutNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)networkCompressionThresholdNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)opPermissionLevelNumericUpDown).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // eulaCheckBox
            // 
            eulaCheckBox.AutoSize = true;
            eulaCheckBox.Location = new Point(6, 22);
            eulaCheckBox.Name = "eulaCheckBox";
            eulaCheckBox.Size = new Size(63, 19);
            eulaCheckBox.TabIndex = 0;
            eulaCheckBox.Text = "Accept";
            eulaCheckBox.UseVisualStyleBackColor = true;
            eulaCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 664);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Settings";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(allowFlightCheckBox);
            panel1.Controls.Add(label27);
            panel1.Controls.Add(allowNetherCheckBox);
            panel1.Controls.Add(label26);
            panel1.Controls.Add(broadcastConsoleToOpsCheckBox);
            panel1.Controls.Add(whiteListCheckBox);
            panel1.Controls.Add(broadcastRconToOpsCheckBox);
            panel1.Controls.Add(label25);
            panel1.Controls.Add(difficultyComboBox);
            panel1.Controls.Add(viewDistanceNumericUpDown);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(useNativeTransportCheckBox);
            panel1.Controls.Add(enableCommandBlockCheckBox);
            panel1.Controls.Add(textFilteringConfigTextBox);
            panel1.Controls.Add(enableJmxMonitoringCheckBox);
            panel1.Controls.Add(syncChunkWritesCheckBox);
            panel1.Controls.Add(enableQueryCheckBox);
            panel1.Controls.Add(spawnProtectionNumericUpDown);
            panel1.Controls.Add(enableRconCheckBox);
            panel1.Controls.Add(spawnNpcsCheckBox);
            panel1.Controls.Add(enableStatusCheckBox);
            panel1.Controls.Add(spawnMonstersCheckBox);
            panel1.Controls.Add(enforceWhitelistCheckBox);
            panel1.Controls.Add(spawnAnimalsCheckBox);
            panel1.Controls.Add(entityBroadcastRangePercentageNumericUpDown);
            panel1.Controls.Add(snooperEnabledCheckBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(forceGamemodeCheckBox);
            panel1.Controls.Add(simulationDistanceNumericUpDown);
            panel1.Controls.Add(functionPermissionLevelNumericUpDown);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(serverPortNumericUpDown);
            panel1.Controls.Add(gamemodeComboBox);
            panel1.Controls.Add(label22);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(serverIpTextBox);
            panel1.Controls.Add(generateStructuresCheckBox);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(generatorSettingTextBox);
            panel1.Controls.Add(resourcePackSha1TextBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(hardcoreCheckBox);
            panel1.Controls.Add(resourcePackPromptTextBox);
            panel1.Controls.Add(hideOnlinePlayersCheckBox);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(levelNameTextBox);
            panel1.Controls.Add(resourcePackTextBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(requireResourcePackCheckBox);
            panel1.Controls.Add(levelSeedTextBox);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(rconPortNumericUpDown);
            panel1.Controls.Add(levelTypeComboBox);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(rconPasswordTextBox);
            panel1.Controls.Add(maxPlayersNumericUpDown);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(rateLimitNumericUpDown);
            panel1.Controls.Add(maxTickTimeNumericUpDown);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(queryPortNumericUpDown);
            panel1.Controls.Add(maxWorldSizeNumericUpDown);
            panel1.Controls.Add(pvpCheckBox);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(preventProxyConnectionsCheckBox);
            panel1.Controls.Add(motdTextBox);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(motd);
            panel1.Controls.Add(playerIdleTimeoutNumericUpDown);
            panel1.Controls.Add(networkCompressionThresholdNumericUpDown);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(onlineModeCheckBox);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(opPermissionLevelNumericUpDown);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 642);
            panel1.TabIndex = 80;
            // 
            // allowFlightCheckBox
            // 
            allowFlightCheckBox.AutoSize = true;
            allowFlightCheckBox.Location = new Point(3, 5);
            allowFlightCheckBox.Name = "allowFlightCheckBox";
            allowFlightCheckBox.Size = new Size(87, 19);
            allowFlightCheckBox.TabIndex = 0;
            allowFlightCheckBox.Text = "allow-flight";
            allowFlightCheckBox.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(160, 1340);
            label27.Name = "label27";
            label27.Size = new Size(112, 15);
            label27.TabIndex = 79;
            label27.Text = "text-filtering-config";
            // 
            // allowNetherCheckBox
            // 
            allowNetherCheckBox.AutoSize = true;
            allowNetherCheckBox.Location = new Point(3, 30);
            allowNetherCheckBox.Name = "allowNetherCheckBox";
            allowNetherCheckBox.Size = new Size(93, 19);
            allowNetherCheckBox.TabIndex = 1;
            allowNetherCheckBox.Text = "allow-nether";
            allowNetherCheckBox.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(90, 1286);
            label26.Name = "label26";
            label26.Size = new Size(101, 15);
            label26.TabIndex = 78;
            label26.Text = "spawn-protection";
            // 
            // broadcastConsoleToOpsCheckBox
            // 
            broadcastConsoleToOpsCheckBox.AutoSize = true;
            broadcastConsoleToOpsCheckBox.Location = new Point(3, 55);
            broadcastConsoleToOpsCheckBox.Name = "broadcastConsoleToOpsCheckBox";
            broadcastConsoleToOpsCheckBox.Size = new Size(164, 19);
            broadcastConsoleToOpsCheckBox.TabIndex = 2;
            broadcastConsoleToOpsCheckBox.Text = "broadcast-console-to-ops";
            broadcastConsoleToOpsCheckBox.UseVisualStyleBackColor = true;
            // 
            // whiteListCheckBox
            // 
            whiteListCheckBox.AutoSize = true;
            whiteListCheckBox.Location = new Point(3, 1415);
            whiteListCheckBox.Name = "whiteListCheckBox";
            whiteListCheckBox.Size = new Size(75, 19);
            whiteListCheckBox.TabIndex = 77;
            whiteListCheckBox.Text = "white-list";
            whiteListCheckBox.UseVisualStyleBackColor = true;
            // 
            // broadcastRconToOpsCheckBox
            // 
            broadcastRconToOpsCheckBox.AutoSize = true;
            broadcastRconToOpsCheckBox.Location = new Point(3, 78);
            broadcastRconToOpsCheckBox.Name = "broadcastRconToOpsCheckBox";
            broadcastRconToOpsCheckBox.Size = new Size(147, 19);
            broadcastRconToOpsCheckBox.TabIndex = 3;
            broadcastRconToOpsCheckBox.Text = "broadcast-rcon-to-ops";
            broadcastRconToOpsCheckBox.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(90, 1394);
            label25.Name = "label25";
            label25.Size = new Size(80, 15);
            label25.TabIndex = 76;
            label25.Text = "view-distance";
            // 
            // difficultyComboBox
            // 
            difficultyComboBox.FormattingEnabled = true;
            difficultyComboBox.Items.AddRange(new object[] { "peaceful", "easy", "normal", "hard" });
            difficultyComboBox.Location = new Point(3, 103);
            difficultyComboBox.Name = "difficultyComboBox";
            difficultyComboBox.Size = new Size(75, 23);
            difficultyComboBox.TabIndex = 4;
            difficultyComboBox.Text = "normal";
            // 
            // viewDistanceNumericUpDown
            // 
            viewDistanceNumericUpDown.Location = new Point(3, 1386);
            viewDistanceNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            viewDistanceNumericUpDown.Name = "viewDistanceNumericUpDown";
            viewDistanceNumericUpDown.Size = new Size(81, 23);
            viewDistanceNumericUpDown.TabIndex = 75;
            viewDistanceNumericUpDown.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 106);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 5;
            label1.Text = "difficulty";
            // 
            // useNativeTransportCheckBox
            // 
            useNativeTransportCheckBox.AutoSize = true;
            useNativeTransportCheckBox.Location = new Point(3, 1361);
            useNativeTransportCheckBox.Name = "useNativeTransportCheckBox";
            useNativeTransportCheckBox.Size = new Size(134, 19);
            useNativeTransportCheckBox.TabIndex = 74;
            useNativeTransportCheckBox.Text = "use-native-transport";
            useNativeTransportCheckBox.UseVisualStyleBackColor = true;
            // 
            // enableCommandBlockCheckBox
            // 
            enableCommandBlockCheckBox.AutoSize = true;
            enableCommandBlockCheckBox.Location = new Point(3, 132);
            enableCommandBlockCheckBox.Name = "enableCommandBlockCheckBox";
            enableCommandBlockCheckBox.Size = new Size(155, 19);
            enableCommandBlockCheckBox.TabIndex = 4;
            enableCommandBlockCheckBox.Text = "enable-command-block";
            enableCommandBlockCheckBox.UseVisualStyleBackColor = true;
            // 
            // textFilteringConfigTextBox
            // 
            textFilteringConfigTextBox.Enabled = false;
            textFilteringConfigTextBox.Location = new Point(3, 1332);
            textFilteringConfigTextBox.Name = "textFilteringConfigTextBox";
            textFilteringConfigTextBox.Size = new Size(151, 23);
            textFilteringConfigTextBox.TabIndex = 73;
            // 
            // enableJmxMonitoringCheckBox
            // 
            enableJmxMonitoringCheckBox.AutoSize = true;
            enableJmxMonitoringCheckBox.Location = new Point(3, 157);
            enableJmxMonitoringCheckBox.Name = "enableJmxMonitoringCheckBox";
            enableJmxMonitoringCheckBox.Size = new Size(151, 19);
            enableJmxMonitoringCheckBox.TabIndex = 6;
            enableJmxMonitoringCheckBox.Text = "enable-jmx-monitoring";
            enableJmxMonitoringCheckBox.UseVisualStyleBackColor = true;
            // 
            // syncChunkWritesCheckBox
            // 
            syncChunkWritesCheckBox.AutoSize = true;
            syncChunkWritesCheckBox.Location = new Point(3, 1307);
            syncChunkWritesCheckBox.Name = "syncChunkWritesCheckBox";
            syncChunkWritesCheckBox.Size = new Size(124, 19);
            syncChunkWritesCheckBox.TabIndex = 72;
            syncChunkWritesCheckBox.Text = "sync-chunk-writes";
            syncChunkWritesCheckBox.UseVisualStyleBackColor = true;
            // 
            // enableQueryCheckBox
            // 
            enableQueryCheckBox.AutoSize = true;
            enableQueryCheckBox.Location = new Point(3, 182);
            enableQueryCheckBox.Name = "enableQueryCheckBox";
            enableQueryCheckBox.Size = new Size(96, 19);
            enableQueryCheckBox.TabIndex = 7;
            enableQueryCheckBox.Text = "enable-query";
            enableQueryCheckBox.UseVisualStyleBackColor = true;
            // 
            // spawnProtectionNumericUpDown
            // 
            spawnProtectionNumericUpDown.Location = new Point(3, 1278);
            spawnProtectionNumericUpDown.Name = "spawnProtectionNumericUpDown";
            spawnProtectionNumericUpDown.Size = new Size(81, 23);
            spawnProtectionNumericUpDown.TabIndex = 71;
            spawnProtectionNumericUpDown.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // enableRconCheckBox
            // 
            enableRconCheckBox.AutoSize = true;
            enableRconCheckBox.Location = new Point(3, 207);
            enableRconCheckBox.Name = "enableRconCheckBox";
            enableRconCheckBox.Size = new Size(90, 19);
            enableRconCheckBox.TabIndex = 8;
            enableRconCheckBox.Text = "enable-rcon";
            enableRconCheckBox.UseVisualStyleBackColor = true;
            // 
            // spawnNpcsCheckBox
            // 
            spawnNpcsCheckBox.AutoSize = true;
            spawnNpcsCheckBox.Location = new Point(3, 1253);
            spawnNpcsCheckBox.Name = "spawnNpcsCheckBox";
            spawnNpcsCheckBox.Size = new Size(90, 19);
            spawnNpcsCheckBox.TabIndex = 70;
            spawnNpcsCheckBox.Text = "spawn-npcs";
            spawnNpcsCheckBox.UseVisualStyleBackColor = true;
            // 
            // enableStatusCheckBox
            // 
            enableStatusCheckBox.AutoSize = true;
            enableStatusCheckBox.Location = new Point(3, 232);
            enableStatusCheckBox.Name = "enableStatusCheckBox";
            enableStatusCheckBox.Size = new Size(97, 19);
            enableStatusCheckBox.TabIndex = 9;
            enableStatusCheckBox.Text = "enable-status";
            enableStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // spawnMonstersCheckBox
            // 
            spawnMonstersCheckBox.AutoSize = true;
            spawnMonstersCheckBox.Location = new Point(3, 1228);
            spawnMonstersCheckBox.Name = "spawnMonstersCheckBox";
            spawnMonstersCheckBox.Size = new Size(114, 19);
            spawnMonstersCheckBox.TabIndex = 69;
            spawnMonstersCheckBox.Text = "spawn-monsters";
            spawnMonstersCheckBox.UseVisualStyleBackColor = true;
            // 
            // enforceWhitelistCheckBox
            // 
            enforceWhitelistCheckBox.AutoSize = true;
            enforceWhitelistCheckBox.Location = new Point(3, 257);
            enforceWhitelistCheckBox.Name = "enforceWhitelistCheckBox";
            enforceWhitelistCheckBox.Size = new Size(115, 19);
            enforceWhitelistCheckBox.TabIndex = 10;
            enforceWhitelistCheckBox.Text = "enforce-whitelist";
            enforceWhitelistCheckBox.UseVisualStyleBackColor = true;
            // 
            // spawnAnimalsCheckBox
            // 
            spawnAnimalsCheckBox.AutoSize = true;
            spawnAnimalsCheckBox.Location = new Point(3, 1203);
            spawnAnimalsCheckBox.Name = "spawnAnimalsCheckBox";
            spawnAnimalsCheckBox.Size = new Size(106, 19);
            spawnAnimalsCheckBox.TabIndex = 68;
            spawnAnimalsCheckBox.Text = "spawn-animals";
            spawnAnimalsCheckBox.UseVisualStyleBackColor = true;
            // 
            // entityBroadcastRangePercentageNumericUpDown
            // 
            entityBroadcastRangePercentageNumericUpDown.Location = new Point(3, 282);
            entityBroadcastRangePercentageNumericUpDown.Name = "entityBroadcastRangePercentageNumericUpDown";
            entityBroadcastRangePercentageNumericUpDown.Size = new Size(75, 23);
            entityBroadcastRangePercentageNumericUpDown.TabIndex = 11;
            entityBroadcastRangePercentageNumericUpDown.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // snooperEnabledCheckBox
            // 
            snooperEnabledCheckBox.AutoSize = true;
            snooperEnabledCheckBox.Enabled = false;
            snooperEnabledCheckBox.Location = new Point(3, 1178);
            snooperEnabledCheckBox.Name = "snooperEnabledCheckBox";
            snooperEnabledCheckBox.Size = new Size(116, 19);
            snooperEnabledCheckBox.TabIndex = 67;
            snooperEnabledCheckBox.Text = "snooper-enabled";
            snooperEnabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 290);
            label2.Name = "label2";
            label2.Size = new Size(193, 15);
            label2.TabIndex = 12;
            label2.Text = "entity-broadcast-range-percentage";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(90, 1157);
            label24.Name = "label24";
            label24.Size = new Size(112, 15);
            label24.TabIndex = 66;
            label24.Text = "simulation-distance";
            // 
            // forceGamemodeCheckBox
            // 
            forceGamemodeCheckBox.AutoSize = true;
            forceGamemodeCheckBox.Location = new Point(3, 311);
            forceGamemodeCheckBox.Name = "forceGamemodeCheckBox";
            forceGamemodeCheckBox.Size = new Size(119, 19);
            forceGamemodeCheckBox.TabIndex = 13;
            forceGamemodeCheckBox.Text = "force-gamemode";
            forceGamemodeCheckBox.UseVisualStyleBackColor = true;
            // 
            // simulationDistanceNumericUpDown
            // 
            simulationDistanceNumericUpDown.Location = new Point(3, 1149);
            simulationDistanceNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            simulationDistanceNumericUpDown.Name = "simulationDistanceNumericUpDown";
            simulationDistanceNumericUpDown.Size = new Size(81, 23);
            simulationDistanceNumericUpDown.TabIndex = 65;
            simulationDistanceNumericUpDown.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // functionPermissionLevelNumericUpDown
            // 
            functionPermissionLevelNumericUpDown.Location = new Point(3, 336);
            functionPermissionLevelNumericUpDown.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            functionPermissionLevelNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            functionPermissionLevelNumericUpDown.Name = "functionPermissionLevelNumericUpDown";
            functionPermissionLevelNumericUpDown.Size = new Size(75, 23);
            functionPermissionLevelNumericUpDown.TabIndex = 14;
            functionPermissionLevelNumericUpDown.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(90, 1128);
            label23.Name = "label23";
            label23.Size = new Size(65, 15);
            label23.TabIndex = 64;
            label23.Text = "server-port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 344);
            label3.Name = "label3";
            label3.Size = new Size(144, 15);
            label3.TabIndex = 15;
            label3.Text = "function-permission-level";
            // 
            // serverPortNumericUpDown
            // 
            serverPortNumericUpDown.Location = new Point(3, 1120);
            serverPortNumericUpDown.Maximum = new decimal(new int[] { -1530494977, 232830, 0, 0 });
            serverPortNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            serverPortNumericUpDown.Name = "serverPortNumericUpDown";
            serverPortNumericUpDown.Size = new Size(81, 23);
            serverPortNumericUpDown.TabIndex = 63;
            serverPortNumericUpDown.Value = new decimal(new int[] { 25565, 0, 0, 0 });
            // 
            // gamemodeComboBox
            // 
            gamemodeComboBox.FormattingEnabled = true;
            gamemodeComboBox.Items.AddRange(new object[] { "survival", "creative", "adventure", "spectator" });
            gamemodeComboBox.Location = new Point(3, 365);
            gamemodeComboBox.Name = "gamemodeComboBox";
            gamemodeComboBox.Size = new Size(75, 23);
            gamemodeComboBox.TabIndex = 16;
            gamemodeComboBox.Text = "survival";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(90, 1099);
            label22.Name = "label22";
            label22.Size = new Size(53, 15);
            label22.TabIndex = 62;
            label22.Text = "server-ip";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 373);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 17;
            label4.Text = "gamemode";
            // 
            // serverIpTextBox
            // 
            serverIpTextBox.Location = new Point(3, 1091);
            serverIpTextBox.Name = "serverIpTextBox";
            serverIpTextBox.Size = new Size(81, 23);
            serverIpTextBox.TabIndex = 61;
            // 
            // generateStructuresCheckBox
            // 
            generateStructuresCheckBox.AutoSize = true;
            generateStructuresCheckBox.Location = new Point(3, 394);
            generateStructuresCheckBox.Name = "generateStructuresCheckBox";
            generateStructuresCheckBox.Size = new Size(129, 19);
            generateStructuresCheckBox.TabIndex = 18;
            generateStructuresCheckBox.Text = "generate-structures";
            generateStructuresCheckBox.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(160, 1070);
            label21.Name = "label21";
            label21.Size = new Size(111, 15);
            label21.TabIndex = 60;
            label21.Text = "resource-pack-sha1";
            // 
            // generatorSettingTextBox
            // 
            generatorSettingTextBox.Location = new Point(3, 419);
            generatorSettingTextBox.Name = "generatorSettingTextBox";
            generatorSettingTextBox.Size = new Size(150, 23);
            generatorSettingTextBox.TabIndex = 19;
            // 
            // resourcePackSha1TextBox
            // 
            resourcePackSha1TextBox.Location = new Point(3, 1062);
            resourcePackSha1TextBox.Name = "resourcePackSha1TextBox";
            resourcePackSha1TextBox.Size = new Size(150, 23);
            resourcePackSha1TextBox.TabIndex = 59;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(159, 427);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 20;
            label5.Text = "generator-settings";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(160, 1041);
            label20.Name = "label20";
            label20.Size = new Size(127, 15);
            label20.TabIndex = 58;
            label20.Text = "resource-pack-prompt";
            // 
            // hardcoreCheckBox
            // 
            hardcoreCheckBox.AutoSize = true;
            hardcoreCheckBox.Location = new Point(3, 448);
            hardcoreCheckBox.Name = "hardcoreCheckBox";
            hardcoreCheckBox.Size = new Size(73, 19);
            hardcoreCheckBox.TabIndex = 21;
            hardcoreCheckBox.Text = "hardcore";
            hardcoreCheckBox.UseVisualStyleBackColor = true;
            // 
            // resourcePackPromptTextBox
            // 
            resourcePackPromptTextBox.Location = new Point(3, 1033);
            resourcePackPromptTextBox.Name = "resourcePackPromptTextBox";
            resourcePackPromptTextBox.Size = new Size(150, 23);
            resourcePackPromptTextBox.TabIndex = 57;
            // 
            // hideOnlinePlayersCheckBox
            // 
            hideOnlinePlayersCheckBox.AutoSize = true;
            hideOnlinePlayersCheckBox.Location = new Point(3, 473);
            hideOnlinePlayersCheckBox.Name = "hideOnlinePlayersCheckBox";
            hideOnlinePlayersCheckBox.Size = new Size(129, 19);
            hideOnlinePlayersCheckBox.TabIndex = 22;
            hideOnlinePlayersCheckBox.Text = "hide-online-players";
            hideOnlinePlayersCheckBox.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(160, 1012);
            label19.Name = "label19";
            label19.Size = new Size(82, 15);
            label19.TabIndex = 56;
            label19.Text = "resource-pack";
            // 
            // levelNameTextBox
            // 
            levelNameTextBox.Location = new Point(3, 498);
            levelNameTextBox.Name = "levelNameTextBox";
            levelNameTextBox.Size = new Size(150, 23);
            levelNameTextBox.TabIndex = 23;
            // 
            // resourcePackTextBox
            // 
            resourcePackTextBox.Location = new Point(3, 1004);
            resourcePackTextBox.Name = "resourcePackTextBox";
            resourcePackTextBox.Size = new Size(150, 23);
            resourcePackTextBox.TabIndex = 55;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(159, 506);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 24;
            label6.Text = "level-name";
            // 
            // requireResourcePackCheckBox
            // 
            requireResourcePackCheckBox.AutoSize = true;
            requireResourcePackCheckBox.Location = new Point(3, 979);
            requireResourcePackCheckBox.Name = "requireResourcePackCheckBox";
            requireResourcePackCheckBox.Size = new Size(143, 19);
            requireResourcePackCheckBox.TabIndex = 54;
            requireResourcePackCheckBox.Text = "require-resource-pack";
            requireResourcePackCheckBox.UseVisualStyleBackColor = true;
            // 
            // levelSeedTextBox
            // 
            levelSeedTextBox.Location = new Point(3, 527);
            levelSeedTextBox.Name = "levelSeedTextBox";
            levelSeedTextBox.Size = new Size(149, 23);
            levelSeedTextBox.TabIndex = 25;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(90, 958);
            label18.Name = "label18";
            label18.Size = new Size(56, 15);
            label18.TabIndex = 53;
            label18.Text = "rcon.port";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(158, 535);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 26;
            label7.Text = "level-seed";
            // 
            // rconPortNumericUpDown
            // 
            rconPortNumericUpDown.Location = new Point(3, 950);
            rconPortNumericUpDown.Maximum = new decimal(new int[] { -1530494977, 232830, 0, 0 });
            rconPortNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            rconPortNumericUpDown.Name = "rconPortNumericUpDown";
            rconPortNumericUpDown.Size = new Size(81, 23);
            rconPortNumericUpDown.TabIndex = 52;
            rconPortNumericUpDown.Value = new decimal(new int[] { 25565, 0, 0, 0 });
            // 
            // levelTypeComboBox
            // 
            levelTypeComboBox.FormattingEnabled = true;
            levelTypeComboBox.Items.AddRange(new object[] { "minecraft:normal", "minecraft:flat", "minecraft:large_biomes", "minecraft:amplified", "minecraft:single_biome_surface" });
            levelTypeComboBox.Location = new Point(3, 556);
            levelTypeComboBox.Name = "levelTypeComboBox";
            levelTypeComboBox.Size = new Size(150, 23);
            levelTypeComboBox.TabIndex = 27;
            levelTypeComboBox.Text = "minecraft:normal";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(160, 929);
            label17.Name = "label17";
            label17.Size = new Size(84, 15);
            label17.TabIndex = 51;
            label17.Text = "rcon.password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(159, 564);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 28;
            label8.Text = "level-type";
            // 
            // rconPasswordTextBox
            // 
            rconPasswordTextBox.Location = new Point(3, 921);
            rconPasswordTextBox.Name = "rconPasswordTextBox";
            rconPasswordTextBox.Size = new Size(151, 23);
            rconPasswordTextBox.TabIndex = 50;
            // 
            // maxPlayersNumericUpDown
            // 
            maxPlayersNumericUpDown.Location = new Point(3, 585);
            maxPlayersNumericUpDown.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            maxPlayersNumericUpDown.Name = "maxPlayersNumericUpDown";
            maxPlayersNumericUpDown.Size = new Size(81, 23);
            maxPlayersNumericUpDown.TabIndex = 29;
            maxPlayersNumericUpDown.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(90, 900);
            label16.Name = "label16";
            label16.Size = new Size(56, 15);
            label16.TabIndex = 49;
            label16.Text = "rate-limit";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(90, 593);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 30;
            label9.Text = "max-players";
            // 
            // rateLimitNumericUpDown
            // 
            rateLimitNumericUpDown.Location = new Point(3, 892);
            rateLimitNumericUpDown.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            rateLimitNumericUpDown.Name = "rateLimitNumericUpDown";
            rateLimitNumericUpDown.Size = new Size(81, 23);
            rateLimitNumericUpDown.TabIndex = 48;
            // 
            // maxTickTimeNumericUpDown
            // 
            maxTickTimeNumericUpDown.Location = new Point(3, 614);
            maxTickTimeNumericUpDown.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            maxTickTimeNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            maxTickTimeNumericUpDown.Name = "maxTickTimeNumericUpDown";
            maxTickTimeNumericUpDown.Size = new Size(81, 23);
            maxTickTimeNumericUpDown.TabIndex = 31;
            maxTickTimeNumericUpDown.Value = new decimal(new int[] { 60000, 0, 0, 0 });
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(90, 871);
            label15.Name = "label15";
            label15.Size = new Size(62, 15);
            label15.TabIndex = 47;
            label15.Text = "query.port";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(90, 622);
            label10.Name = "label10";
            label10.Size = new Size(83, 15);
            label10.TabIndex = 32;
            label10.Text = "max-tick-time";
            // 
            // queryPortNumericUpDown
            // 
            queryPortNumericUpDown.Location = new Point(3, 863);
            queryPortNumericUpDown.Maximum = new decimal(new int[] { -1530494977, 232830, 0, 0 });
            queryPortNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            queryPortNumericUpDown.Name = "queryPortNumericUpDown";
            queryPortNumericUpDown.Size = new Size(81, 23);
            queryPortNumericUpDown.TabIndex = 46;
            queryPortNumericUpDown.Value = new decimal(new int[] { 25565, 0, 0, 0 });
            // 
            // maxWorldSizeNumericUpDown
            // 
            maxWorldSizeNumericUpDown.Location = new Point(3, 643);
            maxWorldSizeNumericUpDown.Maximum = new decimal(new int[] { 29999984, 0, 0, 0 });
            maxWorldSizeNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            maxWorldSizeNumericUpDown.Name = "maxWorldSizeNumericUpDown";
            maxWorldSizeNumericUpDown.Size = new Size(81, 23);
            maxWorldSizeNumericUpDown.TabIndex = 33;
            maxWorldSizeNumericUpDown.Value = new decimal(new int[] { 29999984, 0, 0, 0 });
            // 
            // pvpCheckBox
            // 
            pvpCheckBox.AutoSize = true;
            pvpCheckBox.Location = new Point(3, 838);
            pvpCheckBox.Name = "pvpCheckBox";
            pvpCheckBox.Size = new Size(46, 19);
            pvpCheckBox.TabIndex = 45;
            pvpCheckBox.Text = "pvp";
            pvpCheckBox.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(90, 651);
            label11.Name = "label11";
            label11.Size = new Size(89, 15);
            label11.TabIndex = 34;
            label11.Text = "max-world-size";
            // 
            // preventProxyConnectionsCheckBox
            // 
            preventProxyConnectionsCheckBox.AutoSize = true;
            preventProxyConnectionsCheckBox.Location = new Point(3, 813);
            preventProxyConnectionsCheckBox.Name = "preventProxyConnectionsCheckBox";
            preventProxyConnectionsCheckBox.Size = new Size(171, 19);
            preventProxyConnectionsCheckBox.TabIndex = 44;
            preventProxyConnectionsCheckBox.Text = "prevent-proxy-connections";
            preventProxyConnectionsCheckBox.UseVisualStyleBackColor = true;
            // 
            // motdTextBox
            // 
            motdTextBox.Location = new Point(3, 672);
            motdTextBox.Name = "motdTextBox";
            motdTextBox.Size = new Size(151, 23);
            motdTextBox.TabIndex = 35;
            motdTextBox.Text = "A Minecraft Server";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(90, 792);
            label14.Name = "label14";
            label14.Size = new Size(110, 15);
            label14.TabIndex = 43;
            label14.Text = "player-idle-timeout";
            // 
            // motd
            // 
            motd.AutoSize = true;
            motd.Location = new Point(160, 680);
            motd.Name = "motd";
            motd.Size = new Size(36, 15);
            motd.TabIndex = 36;
            motd.Text = "motd";
            // 
            // playerIdleTimeoutNumericUpDown
            // 
            playerIdleTimeoutNumericUpDown.Location = new Point(3, 784);
            playerIdleTimeoutNumericUpDown.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            playerIdleTimeoutNumericUpDown.Name = "playerIdleTimeoutNumericUpDown";
            playerIdleTimeoutNumericUpDown.Size = new Size(81, 23);
            playerIdleTimeoutNumericUpDown.TabIndex = 42;
            // 
            // networkCompressionThresholdNumericUpDown
            // 
            networkCompressionThresholdNumericUpDown.Location = new Point(3, 701);
            networkCompressionThresholdNumericUpDown.Maximum = new decimal(new int[] { 1500, 0, 0, 0 });
            networkCompressionThresholdNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            networkCompressionThresholdNumericUpDown.Name = "networkCompressionThresholdNumericUpDown";
            networkCompressionThresholdNumericUpDown.Size = new Size(81, 23);
            networkCompressionThresholdNumericUpDown.TabIndex = 37;
            networkCompressionThresholdNumericUpDown.Value = new decimal(new int[] { 256, 0, 0, 0 });
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(90, 763);
            label13.Name = "label13";
            label13.Size = new Size(113, 15);
            label13.TabIndex = 41;
            label13.Text = "op-permission-level";
            // 
            // onlineModeCheckBox
            // 
            onlineModeCheckBox.AutoSize = true;
            onlineModeCheckBox.Location = new Point(3, 730);
            onlineModeCheckBox.Name = "onlineModeCheckBox";
            onlineModeCheckBox.Size = new Size(95, 19);
            onlineModeCheckBox.TabIndex = 38;
            onlineModeCheckBox.Text = "online-mode";
            onlineModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(90, 709);
            label12.Name = "label12";
            label12.Size = new Size(178, 15);
            label12.TabIndex = 40;
            label12.Text = "network-compression-threshold";
            // 
            // opPermissionLevelNumericUpDown
            // 
            opPermissionLevelNumericUpDown.Location = new Point(3, 755);
            opPermissionLevelNumericUpDown.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            opPermissionLevelNumericUpDown.Name = "opPermissionLevelNumericUpDown";
            opPermissionLevelNumericUpDown.Size = new Size(81, 23);
            opPermissionLevelNumericUpDown.TabIndex = 39;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(eulaCheckBox);
            groupBox2.Location = new Point(390, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(148, 66);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "EULA";
            // 
            // button1
            // 
            button1.Location = new Point(390, 86);
            button1.Name = "button1";
            button1.Size = new Size(96, 23);
            button1.TabIndex = 3;
            button1.Text = "Save Settings";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // serverSettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(550, 681);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "serverSettingsForm";
            Text = "serverSettingsForm";
            Load += serverSettingsForm_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)viewDistanceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)spawnProtectionNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)entityBroadcastRangePercentageNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)simulationDistanceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)functionPermissionLevelNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)serverPortNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)rconPortNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxPlayersNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)rateLimitNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxTickTimeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)queryPortNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxWorldSizeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerIdleTimeoutNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)networkCompressionThresholdNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)opPermissionLevelNumericUpDown).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox eulaCheckBox;
        private GroupBox groupBox1;
        private CheckBox allowFlightCheckBox;
        private GroupBox groupBox2;
        private CheckBox broadcastRconToOpsCheckBox;
        private CheckBox broadcastConsoleToOpsCheckBox;
        private CheckBox allowNetherCheckBox;
        private CheckBox enableCommandBlockCheckBox;
        private Label label1;
        private ComboBox difficultyComboBox;
        private CheckBox enforceWhitelistCheckBox;
        private CheckBox enableStatusCheckBox;
        private CheckBox enableRconCheckBox;
        private CheckBox enableQueryCheckBox;
        private CheckBox enableJmxMonitoringCheckBox;
        private Label label3;
        private NumericUpDown functionPermissionLevelNumericUpDown;
        private CheckBox forceGamemodeCheckBox;
        private Label label2;
        private NumericUpDown entityBroadcastRangePercentageNumericUpDown;
        private CheckBox hardcoreCheckBox;
        private Label label5;
        private TextBox generatorSettingTextBox;
        private CheckBox generateStructuresCheckBox;
        private Label label4;
        private ComboBox gamemodeComboBox;
        private NumericUpDown opPermissionLevelNumericUpDown;
        private Label label6;
        private TextBox levelNameTextBox;
        private CheckBox hideOnlinePlayersCheckBox;
        private Label label7;
        private TextBox levelSeedTextBox;
        private ComboBox levelTypeComboBox;
        private NumericUpDown maxPlayersNumericUpDown;
        private Label label8;
        private Label label9;
        private Label label10;
        private NumericUpDown maxTickTimeNumericUpDown;
        private NumericUpDown maxWorldSizeNumericUpDown;
        private Label label11;
        private NumericUpDown networkCompressionThresholdNumericUpDown;
        private Label motd;
        private TextBox motdTextBox;
        private Label label14;
        private NumericUpDown playerIdleTimeoutNumericUpDown;
        private Label label13;
        private Label label12;
        private CheckBox onlineModeCheckBox;
        private CheckBox preventProxyConnectionsCheckBox;
        private TextBox rconPasswordTextBox;
        private Label label16;
        private NumericUpDown rateLimitNumericUpDown;
        private Label label15;
        private NumericUpDown queryPortNumericUpDown;
        private CheckBox pvpCheckBox;
        private Label label18;
        private NumericUpDown rconPortNumericUpDown;
        private Label label17;
        private Label label19;
        private TextBox resourcePackTextBox;
        private CheckBox requireResourcePackCheckBox;
        private Label label20;
        private TextBox resourcePackPromptTextBox;
        private Label label22;
        private TextBox serverIpTextBox;
        private Label label21;
        private TextBox resourcePackSha1TextBox;
        private TextBox textFilteringConfigTextBox;
        private CheckBox syncChunkWritesCheckBox;
        private NumericUpDown spawnProtectionNumericUpDown;
        private CheckBox spawnNpcsCheckBox;
        private CheckBox spawnMonstersCheckBox;
        private CheckBox spawnAnimalsCheckBox;
        private CheckBox snooperEnabledCheckBox;
        private Label label24;
        private NumericUpDown simulationDistanceNumericUpDown;
        private Label label23;
        private NumericUpDown serverPortNumericUpDown;
        private Label label27;
        private Label label26;
        private CheckBox whiteListCheckBox;
        private Label label25;
        private NumericUpDown viewDistanceNumericUpDown;
        private CheckBox useNativeTransportCheckBox;
        private Panel panel1;
        private Button button1;
    }
}