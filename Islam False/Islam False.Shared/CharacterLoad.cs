﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Islam_False
{
    class CharacterLoad
    {
        public static List<Character> addItem()
        {
            List<Character> charactersList = new List<Character>();
            charactersList.Add(new Character { characterName = "Muhammad Ali", characterImage = "Assets/ali.png", characterInfo = "Easily the most prominent Muslim sports figure of our time, Muhammad Ali captured the hearts of Americans with his word play and supreme boxing skill. He was the Greatest Boxer Ever Born on Face of the earth who won every big Boxing Title. Muhammad Ali beat more champions and top contenders than any heavyweight champion in history." });
            charactersList.Add(new Character { characterName = "Ahmed Zewail", characterImage = "Assets/zwl.png", characterInfo = "An Egyptian scientist, known as the \"father of femtochemistry\", he won the 1999 Nobel Prize in Chemistry for his work on the transition states of chemical reactions using femtosecond spectroscopy and became the first Egyptian scientist to win a Nobel Prize in a scientific field. He is the Linus Pauling Chair Professor Chemistry, Professor of Physics and the director of the Physical Biology Centre for the Ultrafast Science and Technology (UST) at the California Institute of Technology. He is the only Muslim chemist to date to be awarded the Nobel Prize and the second Muslim scientist." });
            charactersList.Add(new Character { characterName = "Dr. Oz", characterImage = "Assets/oz.png", characterInfo = "Mehmet Cengiz Oz, not only gives us practical medical advice to apply to our daily lives, but is also a Turkish-American Muslim. He was declared one of the top 500 influential Muslims of 2009." });
            charactersList.Add(new Character { characterName = "Muhammad Anwar al-Sadat", characterImage = "Assets/sdt.png", characterInfo = " The first Muslim to receive a Nobel. He was the third President of Egypt. He, along with Menachem Begin was awarded 1978 Nobel Peace Prize \"for their contribution to the two frame agreements on peace in the Middle East, and on peace between Egypt and Israel, which were signed at Camp David on September 17, 1978\"." });
            charactersList.Add(new Character { characterName = "Malcolm X", characterImage = "Assets/x.png", characterInfo = " Fought strongly for black power and black nationalism as a Muslim. He was a leader of the Nation of Islam before being assassinated in 1965." });
            charactersList.Add(new Character { characterName = "Mohamed El Baradei", characterImage = "Assets/brd.png", characterInfo = "The 2005 Nobel Peace Prize was jointly awarded to El Baradei and IAEA \"for their efforts to prevent nuclear energy from being used for military purposes and to ensure that nuclear energy for peaceful purposes is used in the safest possible way\". He was the second Egyptian to be awarded Nobel Peace Prize (2005)." });
            charactersList.Add(new Character { characterName = "Naguib Mahfouz", characterImage = "Assets/ng.png", characterInfo = "The 1988 Nobel Prize in Literature was given to Naguib Mahfouz \"who, through works rich in nuance—now clear-sightedly realistic, now evocatively ambiguous—has formed an Arabian narrative art that applies to all mankind\". He was the first Muslim author to receive such a prize." });
            charactersList.Add(new Character { characterName = "Dave Chappelle", characterImage = "Assets/dv.png", characterInfo = "An American comedian, screenwriter, television and film producer, and actor. In 2003, he became more widely known for his sketch comedy television series, Chappelle's Show, co-written with Neal Brennan, which ran until his retirement from the show two years later. By 2006, Chappelle was called \"the comic genius of America\" by Esquire and, in 2013, \"the best\" by a Billboard writer. The show continues to run in popular late-night syndication and on television networks around the world. Comedy Central ranks him No. 43 in \"the 100 Greatest Stand-Ups of All Time.\"" });
            charactersList.Add(new Character { characterName = "Kareem Abdul Jabbar", characterImage = "Assets/jabbar.png", characterInfo = "3x NCAA Champion at UCLA, All-Time Leading Scorer in NBA History, 6x NBA Champion, 6x NBA MVP, 2x NBA Finals MVP, 19x NBA All-Star.Kareem has always been great at basketball. He dominated in high school, college and the pros. He invented one of the most unguardable shots in NBA history and even named it. The \"skyhook\" helped him become the NBA's all-time leading scorer with 38,387 points—the closest active player is Kobe with 29,484 points." });
            charactersList.Add(new Character { characterName = "Shaquille O'Neal", characterImage = "Assets/on.png", characterInfo = "1990 NCAA AP Player of the Year, 4x NBA Champion, 3x NBA Finals MVP, 15-time NBA All-Star, 1993 NBA Rookie of ther Year. The man who revolutionized the NBA over the past 15 years. Shaq won three straight in L.A., nabbed another in Miami, gave the world Kazaam, and now he's Charles Barkley's road dog on TNT ragging on NBA players on a nightly basis. Any list of Muslim athletes wouldn't be complete without the Shaq Daddy, that and he'll have a spot when we drop our \"Greatest Players That Got Old and Joined Any Team That Would Take Them\" list." });
            charactersList.Add(new Character { characterName = "Mohamed Salah", characterImage = "Assets/salah.png", characterInfo = "An Egyptian professional footballer who plays for Italian club Fiorentina, on loan from English club Chelsea, and the Egypt national team as a winger. As well as representing the Egyptian national team at an early age, he also participated in the 2011 FIFA U-20 World Cup and the 2012 Summer Olympics. He won the Swiss Super League in his first season with Basel, and was awarded the CAF Most Promising African Talent of the Year in 2012. In 2013, he was awarded the SAFP Golden Player award for being the best player in the Swiss Super League." });
            charactersList.Add(new Character { characterName = "Franck Ribery", characterImage = "Assets/r.png", characterInfo = " Also known as Bilal Yusuf Mohammed as an adopted name since his conversion in 2006 to Islam, is a French international footballer who plays for German club Bayern Munich in the Bundesliga and for the France national football team. he is known for pace energy, and great skill and precise passing. also known as fast, tricky and an excellent dribbler, great control with the ball at his feet. Since joining Bayern, he has been recognized on the world stage as one of the best French players of his generation." });
            charactersList.Add(new Character { characterName = "Mesut Ozil", characterImage = "Assets/ozl.png", characterInfo = "A German footballer who gained international attention during the 2010 FIFA World Cup won by Germany and was nominated for the Golden Ball Award, which is awarded to the tournament's best player. On transfer deadline day of summer 2013, he moved to Arsenal for a club-record fee of £42.5 million. The transfer makes him the most expensive German football player of all time. Özil is acclaimed for his finesse and improvisation as an attacking midfielder. His style and ability for providing assists for his team-mates has been compared by former manager José Mourinho to that of Real Madrid legend Zinedine Zidane. In 2011, Özil ranked first in assists in major European and domestic competitions with 25. In 2012, he ranked first in assists in La Liga with 17. He was also one of the top assist providers in the 2010 FIFA World Cup and UEFA Euro 2012 with three in both tournaments." });
            return charactersList;
        }
    }
}