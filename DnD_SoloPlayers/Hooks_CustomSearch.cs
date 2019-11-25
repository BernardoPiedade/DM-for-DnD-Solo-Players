using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DnD_SoloPlayers
{
    public partial class Hooks_CustomSearch : Form
    {
        List<string> answer = new List<string>();
        List<string> tempList = new List<string>();

        public Hooks_CustomSearch()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void Search_Hooks_Click(object sender, EventArgs e)
        {

            try
            {
                //Adventure hooks
                answer.Add("A night hag is willing to stop terrorizing the locals if you can retrive the linen wraps of a mummy for her which she wants to use to tie bows in her mangy hair with.");
                answer.Add("A clutch of kobolds(5) is building and painting giant wooden dinosaur puppets which they are driving around to scare away local villagers in order to steal their food, water, and gold.");
                answer.Add("A wildly ambitious farmer imported a bunch of dinosaurs because \"they have big eggs\". \r\nAs you might imagine, this has gone poorly for everyone involved.");
                answer.Add("You find a map of a well-known beginner dungeon complex that seems to indicate there is a really big treasure hiden in a secret room, no one was able to find that room.");
                answer.Add("People are going missing in town. \r\nStrangely, in their place, statues of the missing people in elegant costumes have been appearing.");
                answer.Add("A nobleman has declared himself \"The King of the Dance\" and has started a perpetual party in his state. \r\nYou have just received an invite.");
                answer.Add("A lich's ex-lover stole his phylactery and is using it to get the unded wizard to date him again.\r\n The lich would like you to kill this person in exchange for several enchanted wands.");
                answer.Add("A portal to the shadowfell has been rediscovered and opened accidentally in the city, and shadowy being are coming through the night.");
                answer.Add("You are chanllenged by one assassin... who is killed by another assassin in front of them, who now also attacks the party.");
                answer.Add("An elven princess has asked you to act as \"adventurer\" entertainer for her sweet 180th birthday party.\r\n She just wants a little fun.");
                answer.Add("A subterranean druid has been lurking in the sewers below a developing city, summoning bees and bears to hamper construction.");
                answer.Add("Rumor holds that an oasis in the desert has diamonds in its lake bed as numerous as the sand.\r\n You're invited to go with another party of 3 rogues.");
                answer.Add("Something has been stalking you through the woods for days.\r\n You know it because of the tracks that were left by them.");
                answer.Add("While sleeping at the Inn, you appear to have been robbed! \r\nThe thief left behind a single flower");
                answer.Add("The party finds a map to an opening into the Underdark. \r\nIt appears to have originally been written in Undercommon.");
                answer.Add("A manic bard claims there is a ledge that, if jumped off of, will open a path to the Feywild.");
                answer.Add("The elven forest kingdom has banned the consumption of meat. \r\nNobles are willing to pay 200 gold pieces per pound of bacon");
                answer.Add("A novelist hires you in order to witness real combat so she can improve her fight scene narrations.");
                answer.Add("You're hired by a distraught mother to prove the innocence of her child before the execution.");
                answer.Add("A local boy has gone missing. \r\nHis friends had dared him to venture into an old, abandoned cottage in the woods outside town. \r\nThat was the last they saw of him.");
                answer.Add("The rotting corpse of a giant is found alongside a well-traveled road. \r\nThe giant looks like it has been dead for weeks, but travelers at a nearby wayside inn swear that it wasn't there when they ventured through yesterday afternoon.");
                answer.Add("Two lovers are having in a very loud spat in the street. \r\nSuddenly, one of them falls dead, their face contorted in a look of horror. \r\nA strange symbol glows on the side of their neck and slowly begins to fade into nothingness.");
                answer.Add("The animals in the nearby area have been acting strangely. \r\nThey no longer seem to fear people, and are all suffering an insatiable hunger for meat... even the herbivores.");
                answer.Add("A shopkeeper, while renovating the cellar of his business, discovers a strange, stone door behind a shelf.");
                answer.Add("A small town is unsure of what to do. \r\n\tA small child's voice can be heard from a long-dry well, but no children in the town are missing. \r\nWhat's more concerning is that every person who has ventured into the well in an attempt to rescue the child has not come back.");
                answer.Add("A man in a long black coat and wide-brimmed hat hastily checks out of an inn. \r\nAs he rushes out the door, a small vial of swirling green liquid falls from his pocket.");
                answer.Add("A farmer rides into town, white as a sheet. \r\nHe claims his scarecrows have been moving closer to his home each day. \r\nThis morning they were outside the windows of his house. \r\nIs this the work of local pranksters, or something else?");
                answer.Add("A tall, handsome man in fine clothes stands in the center of a crossroads. \r\nHe seems to know your name and says he has information that would be very valuable to you if you choose to return to this spot tonight when the moon is at its apex.");
                answer.Add("The stuffed head of a fantastic beast that adorns a place above the mantle in a popular local tavern suddenly comes to life and screams something in a strange language before bursting into flames.");
                answer.Add("Locals say a star fell from the sky last night and landed somewhere nearby.");
                answer.Add("Every mirror in town ceases to show reflections, but rather gives glimpses into a shadowy keep.");
                answer.Add("The sound of yelling echoes in the night as a band of villagers, armed with torches and pitchforks, gather outside a home, demanding the residents surrender their young daughter.");
                answer.Add("A cloaked man in a dark corner of the tavern tells you he has work for them but promptly dies, a dagger in his back and a sealed letter in his hand.");
                answer.Add("A concerned father approaches you at a tavern and asks for your help. \r\nHis daughter is seeing a man and he doesn't approve. \r\nHe pleads you to end the union. \r\nThe only catch; his daughter has died two years ago.");
                answer.Add("An innkeeper informs the players that a package arrived for them last night. \r\nIt is a small silver locket with a date engraved on it. \r\nThe date is one week from today.");
                answer.Add("The caretaker of a local cemetery is screaming that there are people in the mausoleums scratching at the doors.");
                answer.Add("Something big has been attacking Farmer Biden's cows. \r\nWhatever it is, it's killed five in the last week, but strangely it hasn't eaten them, only drained them of their blood.");
                answer.Add("Late at night, the sound of far-off drums can be heard in the darkness. \r\nWar drums, and lots of them.");
                answer.Add("In a large city, to rival street gangs vie for control over a neighborhood, leaving many innocent bystanders dead. \r\nThe local thieve' guild sits back and waits to endorse the winner.");
                answer.Add("A city official approaches the party discreetly, offering them a fair sum of money to kill her husband. \r\nShe then reveals her husband died two weeks ago but has been lurking the streets ever since.");
                answer.Add("A new noble from an unknown house arrived in the city last month. \r\nAround the same time, several vagrants in the area started to vanish.");
                answer.Add("Someone has hired assassins to eliminate a single member of the party, but who is behind the plot and for what reason?");
                answer.Add("A nomadic barbarian tribe is passing uncomfortably close to town and officials, as well as the citizens, are getting very nervous.");
                answer.Add("A mysterious island suddenly appears off the shore of a stretch of coast or a lake.");
                answer.Add("A mysterious island suddenly appears in the sky over a town or city.");
                answer.Add("A raven flies through an open window and lands on the floor, seemingly dead, with a message attached to its leg. \r\nThe raven then promptly transforms into a bloodied man.");
                answer.Add("A new brothel opens up nearby, but strangely they charge their patrons nothing. \r\nWhat's the catch?");
                answer.Add("A woman storms up to one of the PCs with a member of the town/city watch, points at them, and yells \"That's the one! \r\nThat's the one that killed my husband!\" ");
                answer.Add("While laying in bed one night in an inn, one of the PCs hears a small thump under their bed. \r\nIt seems to be a journal that had somehow been dislodged from its hidden resting place. \r\nIt details an extensive plot to assassinate a prominent leader in a town three days away. \r\nThe last date in the journal is two days ago.");
                answer.Add("The owner of a nearby orchard has been complaining that his trees keep changing positions during the night.");
                answer.Add("A young boy approaches a PC and hands them a heavy, leatherbound tome with a heavy lock on it and whispers \"I'm sorry\" before running off in the other direction.");
                answer.Add("A local baker whose business was failing suddenly manages to turn things around with her new, delicious meat pies. \r\nMeanwhile, unattended children have been vanishing at an alarming rate. ");
                answer.Add("A witch wants you to retrieve a sapling from a nearby dark forest which has many dangerous creatures. After you manage to get the sapling and return to the witch, you soon realize that you must fight off many angry treants that were protecting said sapling.");
                answer.Add("A town has been unresponsive to couriers and anyone who has visited it hasn’t returned and when the players enter it seems like a maze and when they don’t look at the exit it disappears so they have to escape");
                answer.Add("A group of adventurers have recently discovered an ancient giant city, filled with lost artifacts and knowledge. The most important of these artifacts have been brought to the king. But after a while it turns out some of them are haunted by the spirits of long dead giants, that aren't pleased by this turn of events.");
                answer.Add("A young man approaches the you and asks you to find a crystal hidden deep below the surface, in a drow-infested cave in exchange for a great sum of money. If you complete this quest he will ask tyou to retrieve a similar crystal from a hostile colony of elves. Then he asks for one last favour, to retrieve a third crystal from a Lich that stole it long ago. Upon receiving the third crystal he will exclaim: \"Finally, I am free!\". He transforms into a giant of unusual size, and it is revealed that he was transformed into a human as punishment for his crimes against the gods. If not stopped the giant will destroy every depiction of a God he can find.");
                answer.Add("Locals hear chants in the nearby ruins.");
                answer.Add("A powerful bard hires you to retrieve a fabled magical instrument from a dead wizard's coffin. The thing is that the wizard died 100 years ago.");
                answer.Add("Catacombs have opened beneath the city, guarded by ancient undead who let no one pass. The entrance has an iron gate replete with moss and two undead guarding it, when you enter there is no natural or artificial light and the undead managed to evolve to see in the dark without any trouble, the insides are made with old wood, doesn't seem secure.");
                answer.Add("You wake up at the Inn not knowing how you got there, everything you had is with you but something new is there too, you now have another face and you name is Zyonp. It's all a dream, an evil wizard likes to have fun by manipulating the others dreams, the thing is, you can't get out until you wake up and if you die, you won't wake up ever again. The town is full of zombies, giant spiders and a baby dragon sleeping in the middle of the town. The dream lasts for 1d6 + 2 hours.");
                answer.Add("Escaping a storm the player runs to a nearby ruin for shelter and bumps into other people who have all done the same. Walking inside a mud-slide covers the entrance and traps them within, where they have to fight their way towards a second exit where upon they encounter plot hints on the way. The people with you are Flint that is just a farmer doesn't even know how to fight, a shy girl that doesn't want to tell her name but it's heavy armored and has a crossbow and also a battle axe.");
                answer.Add("Somewhere in the town, there's a man who never leaves his house and is always developing something. He has only left his house once and never again, the rest of the town doesn't know how he eats and the guards can't enter because of some magic spell");
                answer.Add("You wake up in the dungeon you designed for fun on paper the night before.");
                answer.Add("While traveling on a mountain road, a traveling goblin bard passes by. He sings about a huge treasure that is hidden high in these mountains.\r\n\r\n(Choose one item from the DMG Magic Itens)");
                answer.Add("After a hard battle, you defeated your enemy and almost knocked him off the cliff. With his last strength he tries to get a hold of the cliff and shouts \r\n\r\n'Without me, you can never defeat him!'");
                answer.Add("While collecting a bounty on pirates, you are attacked by a Kraken and must team up to survive.");
                answer.Add("Reports of livestock deaths lead you to a remote field. The scarecrows turn to watch you pass.");
                answer.Add("A distant figure appears every night when you stop to camp.\r\nEach night it gets closer.");

                //Campaign Hooks

                answer.Add("The locals of Foltard-beside-beach have stopped paying taxes, the ruler of the realm has requested that you go and persuade them to pay before they have to send lass diplomatic people");
                answer.Add("You hear an old lady talk about the four Genie Princes trapped in their four individual lamps, and the one who frees them will be gifted a temple overflowing with treasures and of course a wish to do with as they please\r\n(It's only a mith you end up finding a chest with 100gp, only after 2 days of looking around for the lamps)");
                answer.Add("The town mage needs someone to retrieve a scroll from a monastery. \r\nThe only issue is that the monastery has been lost in the jungle for 300 years... \r\nOh, and the jungle is filled with dark fey elephants.");
                answer.Add("A suit of animated armor was seen fleeing the castle after snatching up the princess's diary. \r\nThe guards are trying to find someone or a party to capture it.\r\nThe princess will pay tremendous amounts of gold to have it returned.");
                answer.Add("Portals to the Feywild are opening in the middle of densely populated citie causing them to be overrun with beats and plants.\r\nThe King has quarantined the cities until the portals are closed.");
                answer.Add("Arriving in a lonely village in the middle of the northern plain known as The Ride, your hero is soon drawn into a quest to retrieve a precious artifact. From there, you will journey even further north, towards the barren waste known as the Tortured Land, in search of an unknown enemy. There are items to collect, codewords to activate and perils to avoid. And of course, many combat encounters!");
                answer.Add("An old man in a dusty, rough-spun robe claims to be a gold dragon in disguise and offers to lead the party to a great treasure.");
                answer.Add("Kobolds have tunneled into the basement of a nearby temple and refuse to leave. ");
                answer.Add("A savage-looking tribe of orcs arrive outside the gates of a small town and offer peace. Is it a trick? ");
                answer.Add("The party receives invitations for a formal ball held at a local noble's estate. \r\nThe invites were sent by a Mr. Dusk.");
                answer.Add("A new drug is running rampant through several cities and is slowly making its way into nearby towns. \r\nThe drug seems to offer the brief ability to perform minor magical spells, but prolonged use leaves the users withered husks.");
                answer.Add("A prestigious bardic college stands accused of manipulating events to write more interesting stories and songs. ");
                answer.Add("A lovelorn man drinks away his sorrows in a tavern because his bride-to-be was kidnapped by bandits along the road after a picnic, and he is too cowardly to rescue her.");
                answer.Add("The players find an abandoned village. \r\nTables are still set with as if for dinner, but with moldering food. \r\nClothes and personal possessions are still found in homes. \r\nEven a minstrel's lute can be found leaned against a stool upon a small stage in the tavern. \r\nIn the center of the village is a well with some rough words scratched into it in elvish (\"A price must be paid\").");
                answer.Add("A dragon has been collecting a tribute from a small town once a week for over fifty years. \r\nTwo weeks ago, the demands stopped and no one has heard anything from the dragon. ");
                answer.Add("A local temple employs what is quite possibly the worst cleric ever. \r\nIt seems that anyone he treats dies. \r\nLuckily his church has given him a duty to make up for his perpetual blunders; they've made him an undertaker as well. \r\nHowever, now anyone he treats comes back to life. ");
                answer.Add("Some local children come running into the tavern looking for their parents, breathless and gasping about a cave behind a waterfall not far outside of town, and the large, unseen thing the began growling inside of it.");
                answer.Add("While arriving in town, the party sees a wanted poster with pictures of their likenesses drawn upon it. \r\nIt states that they are wanted for murder, extortion, blackmail, thievery, and arson. \r\nThey are extremely dangerous and there is a significant reward for their capture... dead or alive.");
                answer.Add("A fire appears in the sky over a town or city. \r\nIt traces a circle around the perimeter. \r\nThen it begins to rain hot pitch.");
                answer.Add("A long abandoned mine suddenly seems to be alive with the sounds of picks and hammers echoing from within... in the middle of the night.");
                answer.Add("An emissary from the elven lands arrives in the city, and suddenly high-ranking government officials begin dropping dead, apparently poisoned. ");
                answer.Add("A devil prince has murdered a god and framed humanity as the culprit. \r\nThe gods now plan to obliterate all life on carth in one year's time unless you can prove humanity's innocence.");
                answer.Add("During a visit with a friendly mage, a spell goes terribly wrong. The characters are thrown back in time to the dawn of civilization where they must protect early man from the first evil dragons.");
                answer.Add("A coven of eldritch hags has escaped their extra-planar prison. They are now summoning other-worldly terrors and setting the loose upon the Material Plane to spread chaos and fear.");
                answer.Add("The party starts as slaves to a massive organization of Ogres who are looking to put the characters into a salt mine for the rest of their lives. As the guard has his back turned for a moment, the party catches a glimpse of a key ring around his belt. Could that unlock their shackles?");
                answer.Add("A merchant sold each party member a lemon item- a cracked hammer, tin-plated armor, etc. The party meets outside his shop, which is ‘coincedentally’ closed.");
                answer.Add("Someone dug a deep pit trap in the road, and a character (or someone else) has fallen in. The party gets together to help them out.");
                answer.Add("The party starts as gladiators and must fight each other. Either money or slavery led them to the colosseum.");
                answer.Add("The group are all on a caravan together travelling from one town to a nearby city. During the day, bandits/orcs raid the caravan, killing and burning some of the wagons before they take off into the wilderness. The group emerges from the ruins of their caravans and are forced into a makeshift group… do you search after the raiders for revenge? Get back items stolen? Or do you continue on your way because you have more important business/mission to attend to?");
                answer.Add("They are all framed for the same murder/robbery, and meet in jail.");
                answer.Add("The party all have ties to a specific Church. They may be members of the Clergy, Enforcers, or someone who has a negative tie to said Church.");
                answer.Add("The party is told about a new tavern that is offering free drinks for it’s grand opening. They all attend and get Shanghaied. They wake up on a slave ship with no equipment and have to escape or take control of the ship.");
                answer.Add("A party member (or several) are all aboard a trade ship headed across the sea to deliver rare goods, when their ship is swallowed by a giant whale/sea monster! Inside it’s gullet are the rest of the party and several other rough-looking sea folk in what looks to be a small town hobbled together out of several shipwrecks.");
                answer.Add("Each character steps into a magical portal leading (players can choose intended destination). A random teleportation mishap puts them together in the bottom of a cave, holding each other’s gear.");
                answer.Add("A strange plague has run rampant through the town, turning nearly everyone to stone. Your party were unaffected and meet in the silent inn, filled with statues.");
                answer.Add("Each party member is being blackmailed (using their respective bonds). The blackmailer has gathered them together with the offer of a score big enough to wipe away their debt.");
                answer.Add("The inn the characters are staying at is shockingly packed. They are forced to share a table. A local tough claims it is her reserved table and demands the party leave, or face her gang…");
                answer.Add("The party each owe an important debt to another party member (have them work out whom owes whom).");
                answer.Add("The party are stuck in the cellar of an evil wizard. Each of them (for their own purposes) attempted to break into the tower and were caught by security.");
                answer.Add("Each party member has been having strange, recurring dreams involving the party as great heroes. They have never met each other before- until this chance meeting on the road…");
                answer.Add("The party wakes up chained to each other in a sandstone room with a portcullis to one side letting in a very bright light, the sound of thousands of people cheering right above them. It takes them a second to process that they’re about to fight another party/a giant creature in gladiatatorial combat.");
                answer.Add("You’re all at a funeral when the deceased comes back to life and lunges at the grieving family.");
                answer.Add("You come to consciousness. Your eyes open, and there’s an immediate numb feeling in your arms. You glance at them, but you’re not laying on your back. You’re chained up. Your body slumps forward with a fierce pain in your shoulders. Chains clamped around your wrists, you look down. Your legs are also chained, not together, but to a wall. Panic sets in as you glance up you see other figures, your friends, all in the same predicament, except one man who seems to be in an iron cage. They are all unconscious to, slowly coming round. You have no gear, you’re stripped back to just your clothes.");
                answer.Add("The party all arrive at a dungeon at the same time, to answer the same advertisement asking for help retrieving an artifact. When they start to argue about whether or not they should work together and split the reward, they get ambushed by a small group of goblins.");
                answer.Add("The party were all passengers on the same ship, when it was caught in a storm. Washing up on shore amping the wreckage, they seem to be the only survivors.");
                answer.Add("Party is chained together, walking behind a wagon. One of the guards mentions that you are all going to be sacrificed.");
                answer.Add("As children, you were each enrolled in a cross-cultural pen pal association. You are meeting the other writers for the first time as adults.");
                answer.Add("You are all victims of a doppelganger who stole each of your identities.");
                answer.Add("The players are invited to the reading of the will of [Random Player’s] Great-Uncle Thrice removed. When they and the rest of the party show up, they discover that Great Uncle Thrice had been something of an adventurer themselves – why, they once acquired the Mysterious MacGuffin from the Temple of the Red Herring! They also discover that they weren’t the only heavily armed group to show up….");
                answer.Add("The party has been asked to help protect a traveling carnival going to the next city over. All is well until one day, the strongman is found wounded in his tent, claiming a member of the carnival is was taken into the woods by whatever attacked him.");
                answer.Add("The party was previously tasked to steal something from a primitive tribe. They managed to take it, but were caught, and now are running away.");
                answer.Add("The party is in an inn, and suddenly people outside start to scream, and a person kicks the door, screaming “Dragon!”.");
                answer.Add("The party is attending to a mutual friend’s wedding. Something bad happens during the event, and drives the party into adventure.");
                answer.Add("The party is in a big castle, attending some sort of event. A random fire begins, and threatens to quickly destroy the whole building. The party must escape, as they decide who, among all the people in danger, they are gonna save.");
                answer.Add("The city is burning. Enemies run through the streets, slaughtering all the citizens they see, with little to no resistance. Luckily, the party members weren’t attacked yet, but they must find a way to leave. All of the city gates are guarded by enemy soldiers.");
                answer.Add("The party is approached by a man who claims to be stuck in a time loop [think Groundhog Day]. He says they already helped him before, and is very close to figuring out how to break free from the loop. He is able to provide the party with any evidence they ask for.");
                answer.Add("The party hears word of a man who claims to be a prophet of the apocalypse. The man was arrested for disturbing the peace, but the party begins to find evidence for his predictions coming true… [that doesn’t mean there will be an apocalypse, just that the man predicted many elements of the plot’s main conflict.]");
                answer.Add("A serious infection broke out in a big city. Authorities set a quarantine, but the party sees a group of people escaping.");
                answer.Add("There are shooting stars in the night sky. They make an incredible light show, that makes most of the citizens stop what they are doing to watch. When it all ends though, people come to their homes to find that their valuable possessions disappeared.");
                answer.Add("The party is next to a city square, where an opposition leader is making a speech to a big crowd. Suddenly, soldiers [who may or may not be aligned with the government] attack the crowd.");
                answer.Add("The group has been pressed into naval service by a corrupt baron and needs to find a way to jump ship.");
                answer.Add("The group (who haven’t met each other yet) are all enjoying their drinks at a tavern when a gang of ruffians breaks down the door demanding protection money. After the situation is resolved, the group finds themselves in trouble with the law.");
                answer.Add("A mysterious figure recruits each of the group members for a heist, only to betray them once the job is done.");
                answer.Add("While sitting in a tavern a man approaches a member of the party and kneels before them. Crying the man tells him he is thankful to see the rightful Lord is alive.");
                answer.Add("The party finds, to their surprise, that they are the only non-cultists staying at the inn.");
                answer.Add("The party are all young citizens of a small town and as their “coming of age” rite, they must explore the tomb of a local hero and bring back an etching from his casket. What they don’t know, is that every rite like this that takes place in the town is more of a game that is set up by the mayor and other officials and townsfolk who have set clever tasks in order to challenge the would be adventurers.");
                answer.Add("The party start as guards to a noble’s gathering on the eve of a revolutionary uprising.");
                answer.Add("The lord is holding a grand tournament. From near and far, people come to participate in the melee and/or archery contests, while the glorious knights come to joust. Along the main road to town stands a huge popular tavern/inn, about a day’s ride from the tournament. It is bursting with travelers on their way to the tournament, among the visitors of course the characters.");
                answer.Add("The characters wake up aboard a plague cart. Their bodies are about to be dumped in a mass grave.");
                answer.Add("The characters are all at the town square to witness the execution of a notorious bandit leader. The bandit’s companions launch a rescue operation without regard to the safety of the audience. (Option: When the hood is drawn off the bandit – or the executioner – one character is shocked to see it’s a relative.)");
                answer.Add("The characters have all grown up together in a small farming community and are expected to take over their fathers’ work. However, one rainy spring evening, a knight leading a company of soldiers comes to muster all able-bodied people in the area. War is coming.");
                answer.Add("The party starts as disparate treasure hunters who have been brought together by a wealthy patron to seek a legendary tome. Little does the party know, the tome is one of unspeakable evil, and their charismatic patron is the leader of a secret organization. An organization bent on destruction/subjugation/apotheosis/something evil.");
                answer.Add("A large gathering has brought the party to one town; a festival, a circus, etc. At night, a band of thieves rummages and steal all the expensive (more than common gear) items in the village. All adventurers are hired to find out who did it and get back all the stolen goods.");
                answer.Add("For reasons of your own, you have each chosen (or been chosen) to join Ye Olde Heroes for Hyre, the largest private security & mercenary company in the land. As the newest recruits you’ve been assigned to the same squad. Your squad leader has just handed you your first assignment.");
                answer.Add("A traveling carnival has rolled into town, and you’ve all decided to check out the attractions. A commotion erupts and you realize that you’re all in the path of an escaped (or was it freed?) angry beast. Its trainer is nowhere to be found; you’re the only ones who can stop it from charging into the big top full of helpless townsfolk.");
                answer.Add("The party has been executed by way of bottomless pit for crimes real or imagined. However, after hours of falling, they find themselves in a bustling underground City with a citizenry full of “executed” peoples. They must find their way back to the surface for their revenge.");
                answer.Add("You arrive at the gates of the reclusive gnome inventor Tinky Tonka’s factory, each carrying the golden ticket that allows you to see what goes on inside. What wonders await!");
                answer.Add("Metal men have come out from an old ruined castle and have begun chopping down the forest. They carry the lumber back to the castle, but no one has gotten close enough to see what it’s being used for.");
                answer.Add("You are each contacted by Sowusi Aletongo, a Thayyan Prince who offers you an incredibly lucrative deal. When you arrive at the agreed upon meeting spot, an abandoned cabin in the forest, you find only the other party members.");
                answer.Add("The surrounding areas are all suffering an extreme drought but this town is having a massive harvest festival. Different rumors intrigue each member enough to make a trip.");
                answer.Add("Heavy rains have washed out all bridges and paths except the main highway. People have formed a caravan to reach higher ground. Your party has all ended up traveling together.");
                answer.Add("A local magistrate has sent his brute squad to round up anyone who looks suspicious. Your party was all gathered up. The magistrate isn’t looking arrest you. He is looking to form a band of strangers to kidnap someone.");
                answer.Add("You have all attended a large banquet. During the feast you have all been knocked unconscious. You wake in the morning and all the guests but you have died.");
                answer.Add("A huge, Violet hurricane came blowing through the town where all the characters happened to be staying. You are trapped for hours together in a cellar while it blows over.");
                answer.Add("Each player owes a favor to a local Lord. A mysterious figure recently came to the Lord and purchased those favors, and now he calls the characters together to collect.");
                answer.Add("You are orphan children and you are part of an orphanage that is self-supporting with agriculture. Suddenly, the golem-worker stops working.");
                answer.Add("Some noble lord has made a call for adventurers to help him clear the goblin infestation out of his land or complete some other quest appropriate to the campaign. Whoever does the best job will win a prize. However, all of you missed the memo that you were supposed to come in teams of (insert party size here). You’re the only ones who showed up alone, so now you’re stuck on a team together.");
                answer.Add("Each of you independently helped stop some crime or disaster just before the campaign began, all for your own reasons. You have all been invited to some ceremony where you will be honored for your participation. During the ceremony, someone who isn’t happy about your deeds attacks, targeting all of you specifically.");
                answer.Add("The players are all trying to kill the same reclusive Lord and have planned thier break ins on the same day.");
                answer.Add("It’s the day of the year every guild in the capital dreads. Every guild must present their annual accounting report to the department of accounting in order to determine if everything is reported correctly and is in order. Each member of the party has drawn the short straw of delivering the books of their respective guilds, and have spent the last 8 hours standing together in line, getting to know one another to pass the time. As the first of the PCs makes it to the front, a commotion can be heard at the entrance…");
                answer.Add("As you fall uncouncious in battle, you hear the god Lathander speak out to Tyr: He is not ready yet, let him go! You wake up from a bird pecking around your clothes. Around you body’s lay on the ground, there are people in the distance. The air smells metallic from the blood around you, the ground is red. You see some others wake up, and your eyes meet. You notice a connection in their eyes. Wounded, what would you like to do.");
                answer.Add("You’re startled into wakefulness by the crow of a rooster. You manage to unstick your eyelids, to find that the pressure on your chest was the rooster itself, who glares at you with homicidal malice and crows again. This sets off the monstrous headache you had only just started to understand you had. You slide off the wooden… shelves, covered with straw? that you were sleeping on and stagger to your feet. NOW the headache hits: this is a hangover only in the sense that the plague is an illness. You are in your only set of fine clothes, now ruined: smeared with mud, dung, broken eggs, straw and the thick, pungent smell of the jug of mysterious liquor you now remember that guy in the hat insisting you drink. A couple of hens peck the ground near your feet. You vomit in the dust and straw in front of you: the chickens investigate. You wash out your mouth with the last sip of stale water from your canteen. Now you can see that you were sleeping on the bench of a wagon, which somehow crashed through the wall of the chicken coop. Vanished are the horses you remember pulling the wagon, too fast across a bridge with the rest of the party in the back. The rest of your party is sprawled across the coop and begins to awaken. The rooster crows again. Gods, it hurts.");
                answer.Add("The party wakes up on a beach in front of a neverending forest that seems to go on for forever, no matter how far they go. They must complete a quest in the woods in order to be allowed to leave.");
                answer.Add("Returning home after a long journey, you’re comforted by the familiar sight of the rolling hills that surround the village and begin thinking about a hot bath and your nice, comfortable bed. Your happiness turns to shock as you crest the hill. How can the entire village have disappeared?");
                answer.Add("An aging wizard wishes to give back to the community and start his own wizarding school. He urgently needs his first ever spell book, but he sold it some years back while travelling the land. Return it and he’ll pay handsomely.");
                answer.Add("The characters are attending a local fair and doing their own things when they hear screaming. The performers at the center of the fair are being attacked. While everyone else rushes away from danger, the heroes put their heads down and charge in.");
                answer.Add("Your party has just finished its first job as official adventurers walking back to the woman who gave you your job when she comes running up, claiming the princess has been assassinated and the group is being framed.");
                answer.Add("The PC were part of a dungeon exploration group. Almost all other npcs apart from the leader, his mage and three of his soldiers met their demise in those heavily trapped dungeon. In the last room, some sort of artifact is displayed on an altar, surrounded by mounds of gold and gemstones. While resting, one of the party overhears a conversation between the leader and his mage assistant. They want to get the artifact and gold to themself. During night, whem everyone seems asleep, you see the leader and his aide at the pedestal where the artifact is. On touch, the leader screams and throws the artifact towards the group, to suddenly get ripped apart by an unknown force. A strong wind seems to suck in all that is close and its getting stronger. You wake up everyone, tske the artifact and run out of the dungeon. Outside, the dungeon collapses and you are stranded in the mountains without gear or rations, only one horse with provisons is still there, while all others fled. Its the PCs and the three soldiers survived.");
                answer.Add("A mummy lord awoken after an erupting volcano teleported their pyramid from the Plane of Fire to the Material Plane. They will not rest until their new home is consumed in fire.");

                //filter

                //save keywords to variable and split them to array.
                string keywords = Keywords_Input.Text;
                string[] arrKey = keywords.Split(',');
                int cont = 0;


                tempList.Clear();
                for (int i = 0; i < answer.Count; i++)
                {
                    string[] tempArr = answer[i].Split(' ');

                    for (int j = 0; j < tempArr.Length; j++)
                    {
                        string palavraSelecionada = tempArr[j];

                        for (int k = 0; k < arrKey.Length; k++)
                        {
                            if (palavraSelecionada.Equals(arrKey[k]))
                            {
                                cont++;
                            }
                        }
                    }

                    if (cont == arrKey.Length)
                    {
                        tempList.Add(answer[i]);
                        cont = 0;
                    }

                }

                Random rnd = new Random();
                int select = rnd.Next(0, tempList.Count);

                textBox1.Text = tempList[select].ToString();
            }
            catch
            {
                textBox1.Text = "No matches were found, maybe try to use other words!?";
            }

        }
    }
}
