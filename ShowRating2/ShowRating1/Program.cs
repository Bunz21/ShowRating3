using System;

namespace ClassObjectTest1
{
    class Program
    {
        static void Main(string[] args)
        {

            Show show1 = new Show("Demon Slayer", "ufotable", 8.52, "Ever since the death of his father, the burden of supporting the family has fallen upon Tanjirou Kamado's shoulders. Though living impoverished on a remote mountain, the Kamado family are able to enjoy a relatively peaceful and happy life. One day, Tanjirou decides to go down to the local village to make a little money selling charcoal. On his way back, night falls, forcing Tanjirou to take shelter in the house of a strange man, who warns him of the existence of flesh-eating demons that lurk in the woods at night.\nWhen he finally arrives back home the next day, he is met with a horrifying sight—his whole family has been slaughtered. Worse still, the sole survivor is his sister Nezuko, who has been turned into a bloodthirsty demon. Consumed by rage and hatred, Tanjirou swears to avenge his family and stay by his only remaining sibling.Alongside the mysterious group calling themselves the Demon Slayer Corps, Tanjirou will do whatever it takes to slay the demons and protect the remnants of his beloved sister's humanity.", 0);
            Show show2 = new Show("Mushoku Tensei: Jobless Reincarnation", "Studio Bind", 8.37, "Despite being bullied, scorned, and oppressed all of his life, a 34-year-old shut-in still found the resolve to attempt something heroic—only for it to end in a tragic accident. But in a twist of fate, he awakens in another world as Rudeus Greyrat, starting life again as a baby born to two loving parents.\nPreserving his memories and knowledge from his previous life, Rudeus quickly adapts to his new environment.With the mind of a grown adult, he starts to display magical talent that exceeds all expectations, honing his skill with the help of a mage named Roxy Migurdia. Rudeus learns swordplay from his father, Paul, and meets Sylphiette, a girl his age who quickly becomes his closest friend.\nAs Rudeus' second chance at life begins, he tries to make the most of his new opportunity while conquering his traumatic past. And perhaps, one day, he may find the one thing he could not find in his old world—love.", 0);
            Show show3 = new Show("Houseki no Kuni", "orange", 8.39, "In the mysterious future, crystalline organisms called Gems inhabit a world that has been destroyed by six meteors. Each Gem is assigned a role in order to fight against the Lunarians, a species who attacks them in order to shatter their bodies and use them as decorations.\nPhosphophyllite, also known as Phos, is a young and fragile Gem who dreams of helping their friends in the war effort.Instead, they are told to compile an encyclopedia because of their delicate condition.After begrudgingly embarking on this task, Phos meets Cinnabar, an intelligent gem who has been relegated to patrolling the isolated island at night because of the corrosive poison their body creates.After seeing how unhappy Cinnabar is, Phos decides to find a role that both of the rejected Gems can enjoy.Houseki no Kuni follows Phos' efforts to be useful and protect their fellow Gems.", 0);
            Show show4 = new Show("Parasyte: The Maxim", "Madhouse", 8.34, "All of a sudden, they arrived: parasitic aliens that descended upon Earth and quickly infiltrated humanity by burrowing into the brains of vulnerable targets. These insatiable beings acquire full control of their host and are able to morph into a variety of forms in order to feed on unsuspecting prey.\nSixteen - year - old high school student Shinichi Izumi falls victim to one of these parasites, but it fails to take over his brain, ending up in his right hand instead.Unable to relocate, the parasite, now named Migi, has no choice but to rely on Shinichi in order to stay alive.Thus, the pair is forced into an uneasy coexistence and must defend themselves from hostile parasites that hope to eradicate this new threat to their species.", 0);
            Show show5 = new Show("Made in Abyss", "Kinema Citrus", 8.66, "The Abyss—a gaping chasm stretching down into the depths of the earth, filled with mysterious creatures and relics from a time long past. How did it come to be? What lies at the bottom? Countless brave individuals, known as Divers, have sought to solve these mysteries of the Abyss, fearlessly descending into its darkest realms. The best and bravest of the Divers, the White Whistles, are hailed as legends by those who remain on the surface.\nRiko, daughter of the missing White Whistle Lyza the Annihilator, aspires to become like her mother and explore the furthest reaches of the Abyss.However, just a novice Red Whistle herself, she is only permitted to roam its most upper layer.Even so, Riko has a chance encounter with a mysterious robot with the appearance of an ordinary young boy.She comes to name him Reg, and he has no recollection of the events preceding his discovery.Certain that the technology to create Reg must come from deep within the Abyss, the two decide to venture forth into the chasm to recover his memories and see the bottom of the great pit with their own eyes.However, they know not of the harsh reality that is the true existence of the Abyss.", 0);
            ShowList lib = new ShowList();
            lib.library = new Show[] {
                show1, show2, show3, show4, show5
            };
            /*Console.WriteLine(lib[0].title); //find out how to use library
            Console.ReadLine();

            /*for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Show " + i + ":" + "\nTitle: " + show1.title + "\n\nStudio: " + show1.author + "\n\nMAL Rating: " + show1.rating + "\n\nSynopsis: " + show1.synopsis);
                do
                {
                    Console.WriteLine("\nGive the show a rating out of 10: ");

                    try
                    {
                        show1.score = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        show1.score = 11; //make it restart
                    }
                } while (show1.score > 10 || show1.score < 0);
                Console.WriteLine("\nYou scored this anime a " + show1.score + " out of 10\nPress ENTER to continue (1/5)");
                Console.ReadLine();
                Console.Clear();
            }*/ //potential to make code less messy, ask all questions in one for loop

            Console.WriteLine("Show 1:\nTitle: " + show1.title + "\n\nStudio: " + show1.author + "\n\nMAL Rating: " + show1.rating + "\n\nSynopsis: " + show1.synopsis);
            do
            {
                Console.WriteLine("\nGive the show a rating out of 10: ");
                
                try
                {
                    show1.score = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    show1.score = 11; //make it restart
                }
            } while (show1.score > 10 || show1.score < 0);
            Console.WriteLine("\nYou scored this anime a " + show1.score + " out of 10\nPress ENTER to continue (1/5)");
            Console.ReadLine();
            Console.Clear();
                 
            Console.WriteLine("Show 2:\nTitle: " + show2.title + "\n\nStudio: " + show2.author + "\n\nMAL Rating: " + show2.rating + "\n\nSynopsis: " + show2.synopsis);
            do
            {
                Console.WriteLine("\nGive the show a rating out of 10: ");

                try
                {
                    show2.score = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    show2.score = 11; //make it restart
                }
            } while (show2.score > 10 || show2.score < 0);
            Console.WriteLine("\nYou scored this anime a " + show2.score + " out of 10\nPress ENTER to continue (2/5)");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Show 3:\nTitle: " + show3.title + "\n\nStudio: " + show3.author + "\n\nMAL Rating: " + show3.rating + "\n\nSynopsis: " + show3.synopsis);
            do
            {
                Console.WriteLine("\nGive the show a rating out of 10: ");

                try
                {
                    show3.score = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    show3.score = 11; //make it restart
                }
            } while (show3.score > 10 || show3.score < 0);
            Console.WriteLine("\nYou scored this anime a " + show3.score + " out of 10\nPress ENTER to continue (3/5)");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Show 4:\nTitle: " + show4.title + "\n\nStudio: " + show4.author + "\n\nMAL Rating: " + show4.rating + "\n\nSynopsis: " + show4.synopsis);
            do
            {
                Console.WriteLine("\nGive the show a rating out of 10: ");

                try
                {
                    show4.score = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    show4.score = 11; //make it restart
                }
            } while (show4.score > 10 || show4.score < 0);
            Console.WriteLine("\nYou scored this anime a " + show4.score + " out of 10\nPress ENTER to continue (4/5)");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Show 5:\nTitle: " + show5.title + "\n\nStudio: " + show5.author + "\n\nMAL Rating: " + show5.rating + "\n\nSynopsis: " + show5.synopsis);
            do
            {
                Console.WriteLine("\nGive the show a rating out of 10: ");

                try
                {
                    show5.score = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    show5.score = 11; //make it restart
                }
            } while (show5.score > 10 || show5.score < 0);
            Console.WriteLine("\nYou scored this anime a " + show5.score + " out of 10\nPress ENTER to continue (5/5)");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Final Scores:\n\nShow 1: " + show1.score + "\nShow 2: " + show2.score + "\nShow 3: " + show3.score + "\nShow 4: " + show4.score + "\nShow 5: " + show5.score);
            Console.WriteLine("\nWould you like to see the difference of your score to the average scores?\nType Y for yes or N for no");
            if (Console.ReadLine() == "y") {
                Console.WriteLine("\nShow 1 Score Difference is: " + show1.GetRatingDifference() + "\nShow 2 Score Difference is: " + show2.GetRatingDifference() + "\nShow 3 Score Difference is: " + show3.GetRatingDifference() + "\nShow 4 Score Difference is: " + show4.GetRatingDifference() + "\nShow 5 Score Difference is: " + show5.GetRatingDifference());
                Console.WriteLine("Press ENTER to close the window");
                Console.ReadLine();
            } else
            {
                Console.WriteLine("Press ENTER to close the window");
            }
            Console.ReadLine();
        }
    }
}
