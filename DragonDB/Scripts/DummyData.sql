INSERT INTO RACE(r_name, r_description)
VALUES
('Dragonborn', 'Born of dragons, as their name proclaims, the dragonborn walk proudly through a world that greets them with fearful incomprehension. Shaped by draconic gods or the dragons themselves, dragonborn originally hatched from dragon eggs as a unique race, combining the best attributes of dragons and humanoids. Some dragonborn are faithful servants to true dragons, others form the ranks of soldiers in great wars, and still others find themselves adrift, with no clear calling in life.'),
('Dwarf', 'Kingdoms rich in ancient grandeur, halls carved into the roots of mountains, the echoing of picks and hammers in deep mines and blazing forges, a commitment 10 clan and traditional, and a burning hatred of goblins and ores-these common threads unite all dwarves.'),
('Elf', 'Elves are a magical people of otherworldly grace, living in the world but not entirely part of it. They live in places of ethereal beauty, in the midst of ancient forests at in silvery spires glittering with faerie light, where soft music drifts through the air and gentle fragrances waft on the breeze. Elves lave nature and magic, art and artistry, music and poetry, and the good things of the world.'),
('Half-Elf', 'Walking in two worlds but truly belonging to neither, half-elves combine what some say are the best qualities of their elf and human parents: human curiosity, inventiveness, and ambition tempered by the refined senses, love of nature, and artistic tastes of the elves. Some half-elves live among humans, set apart by their emotional and physical differences, watching friends and loved ones age while time barely touches them. Others live with the elves, growing restless as they reach adulthood in the timeless elven realms, while their peers continue to live as children. Many half-elves, unable to fit into either society, choose lives of solitary wandering or join with other misfits and outcasts in the adventuring life.'),
('Half-Orc', 'Whether united under the leadership of a mighty warlock or having fought to a standstill after years of conflict, ore and human tribes sometimes form alliances, joining forces into a larger horde lo the terror of civilized lands nearby. When these alliances are sealed by marriages, half-ores are born. Some half-ores rise to become proud chiefs of ore tribes, their human blood giving them an edge over their full-blooded ore rivals. Some venture into the world lo prove their worth among humans and other more civilized races. Many of these become adventurers, achieving greatness for their mighty deeds and notoriety for their barbaric customs and savage fury.'),
('Halfling', 'The comforts of home are the goals of most halflings lives: a place to settle in peace and quiet, far from marauding monsters and lashing armies; a blazing tire and a generous meal; fine drink and fine conversation. Though some halflings live out their days in remote, agricultural communities, others form nomadic bands that travei constantly, lured by the open road and the wide horizon to discover the wonders of new lands and peoples. But even these wanderers love peace, food, hearth, and home, though home might be a wagon jostling along an dirt road or a raft floating downriver.'),
('Human', 'In the reckonings of most worlds, humans are the youngest of the common races, late to arrive on the world scene and short-lived in comparison to dwarves, elves, and dragons. Perhaps it is because of their shorter lives that they strive to achieve as much as they can in the years they are given. Or maybe they feel they have something to prove to the elder races, and that is why they build their mighty empires on the foundation of conquest and trade. Whatever drives them. humans are the innovators, the achievers, and the pioneers of the worlds.'),
('Teifling', 'To be greeted with stares and whispers, to suffer violence and insult on the street, to see mistrust and fear in every eye: this is the lot of the tiefling. And to twist the knife, tieflings know that this is because a pact struck generations ago infused the essence of Asmodeus-overlord of the Nine Hells-into their bloodline. Their appearance and their nature are not their fault but the result of an ancient sin, for which they and their children and their childrens children will always be held accountable.')

INSERT INTO CLASS
VALUES
('Barbarian', 'd12', null),
('Bard', 'd8', 'CHA'),
('Cleric', 'd8', 'WIS'),
('Druid', 'd8', 'WIS'),
('Fighter', 'd10', null),
('Monk', 'd8', null),
('Paladin', 'd10', 'CHA'),
('Ranger', 'd10', 'WIS'),
('Rogue', 'd8', null),
('Sorcerer', 'd6', 'CHA'),
('Warlock', 'd8', 'CHA'),
('Wizard', 'd6', 'INT')

INSERT INTO FEATS
VALUES
('Horde Breaker', 'Class: Ranger', 'Once on each of your turns when you make a weapon attack, you can make another attack with the same weapon against a different creature that is within 5 feet of the original target and within range of your weapon.')

INSERT INTO SPELLS
VALUES
('Fire Bolt', 'Evocation', 0, '1 action', '120 feet', '1 creature/object within range', 1, 1, null, 0, 'Instantaneous', 'You hurl a mote of fire at a creature or object within range. Make a ranged spell attack against the target. On a hit, the target takes 1d10 fire damage. A flammable object hit by this spell ignites if it isn’t being worn or carried.')

--Mithran
INSERT INTO ABILITY
VALUES
(16, 17, 10, 12, 13, 8)

INSERT INTO SKILL
VALUES
(3, 0, -1, 6, 1, -1, 3, 1, -1, 0, -1, 3, 1, 4, -1, 3, 6, 3)

INSERT INTO SPELLS_SLOTS
VALUES
(4, 2, 0, 0, 0, 0, 0, 0, 0),
(2, 0, 0, 0, 0, 0, 0, 0, 0)

INSERT INTO CHARACTER
VALUES
(
'Mithran Kharak Mondulé',
3,
'Neutral Good',
18,
34,
0,
0,
1,
1,
2,
1,
0,
13,
3,
30,
3500,
0,
3)

INSERT INTO CHARACTER_BACKGROUND
VALUES
(1, 'Appearance', 'In his 306th year, Mithran is still in warrior health and trains regularly to maintain his skill in combat, and his formidable physique. Though he stands at only 5 ft 10 in and weighs only 170 lbs, he demonstrates significant strength while utilizing the famed athletic ability of the elven race.')

INSERT INTO PROFICIENCY
VALUES
('Common', 'Language'),
('Elven', 'Language')

INSERT INTO CHARACTER_PROFICIENCIES
VALUES
(1, 1),
(1, 2)

INSERT INTO CHARACTER_FEATS
VALUES
(1, 1)

INSERT INTO ITEM
VALUES
(1, 'Shortswords', 2, 2, 'A pair of fine elven blades.')

INSERT INTO CHARACTER_ATTACK
VALUES
(1, 'Shortwords', 'STR', 0, 1, 'Melee', '2d6 + STR Piercing', null, null)

INSERT INTO CHARACTER_CLASS
VALUES
(1, 8, 5, 1)

INSERT INTO CHARACTER_SPELLBOOK
VALUES
(1,1)
