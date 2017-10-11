using Islam_False.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Islam_False
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Wrong_Facts : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        public Wrong_Facts()
        {
            this.InitializeComponent();

            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += this.NavigationHelper_LoadState;
            this.navigationHelper.SaveState += this.NavigationHelper_SaveState;
        }

        /// <summary>
        /// Gets the <see cref="NavigationHelper"/> associated with this <see cref="Page"/>.
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        /// <summary>
        /// Gets the view model for this <see cref="Page"/>.
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>
        private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }
        private void Terrorists(object sender, TappedRoutedEventArgs e)
        {
            factLoad(1);
            this.Frame.Navigate(typeof(Fact_Correction));
        }

        private void Sword(object sender, TappedRoutedEventArgs e)
        {
            factLoad(2);
            this.Frame.Navigate(typeof(Fact_Correction));
        }

        private void Women(object sender, TappedRoutedEventArgs e)
        {
            factLoad(3);
            this.Frame.Navigate(typeof(Fact_Correction));
        }

        private void Savages(object sender, TappedRoutedEventArgs e)
        {
            factLoad(4);
            this.Frame.Navigate(typeof(Fact_Correction));
        }

        private void Bride(object sender, TappedRoutedEventArgs e)
        {
            factLoad(5);
            this.Frame.Navigate(typeof(Fact_Correction));
        }

        private void Jihad(object sender, TappedRoutedEventArgs e)
        {
            factLoad(6);
            this.Frame.Navigate(typeof(Fact_Correction));
        }

        private void Religion(object sender, TappedRoutedEventArgs e)
        {
            factLoad(7);
            this.Frame.Navigate(typeof(Fact_Correction));
        }

        private void Children(object sender, TappedRoutedEventArgs e)
        {
            factLoad(8);
            this.Frame.Navigate(typeof(Fact_Correction));
        }

        private void Jesus(object sender, TappedRoutedEventArgs e)
        {
            factLoad(9);
            this.Frame.Navigate(typeof(Fact_Correction));
        }

        private void Arabs(object sender, TappedRoutedEventArgs e)
        {
            factLoad(10);
            this.Frame.Navigate(typeof(Fact_Correction));
        }
        private void factLoad(int flag)
        {
            if (flag == 1)
            {
                Globals.fact = "Muslims are terrorists";
                Globals.factCorrection = "This is by far the biggest misconception of Islam, given unfairly by stereotyping and the public image that the media gives. Has anyone else noticed how when a specific group of people attack another group of people it is labeled as a ‘hate crime’, but when a Muslim opens fire on anybody it is quickly regarded as ‘terrorism’.\n\nMany political dictators and officials or extremist groups use the name of Islam as a strategy to garner followers and attention when many of their practices go against the true basis of Islam.\n\nThe media has also portrayed Islam as a cult or a club where if you join you become a terrorist and that is now part of your agenda. However all over the world people practice Islam in the true form and use it as a way of life.\n\nThere are many verses in the Quran that go against the idea of terrorism. Some of these verses include “fight in the way of Allah those that fight you but do not transgress limits for god does not love transgressors.” This basically means do not fight except in self defense and even in doing so do not go beyond defense. Another verse states “if they seek peace, then you seek peace,” which means do not attack people for no reason or kill innocent people.\nThere is nowhere in Islam, whether it be in the Quran or the teachings of Muhammad, that promotes the killing of innocent people.";
                Globals.factImage = "/Assets/terrorist.png";
            }
            else if (flag == 2)
            {
                Globals.fact = "Islam was spread by the sword";
                Globals.factCorrection = "Historian De lacey O’Leary states “History makes it clear however, that the legend of fanatical Muslims sweeping through the world and forcing Islam at the point of the sword upon conquered races is one of the most fantastically absurd myths that historians have ever repeated.”\n\nThere is no record in history that shows people being forced by sword point to convert to Islam.\n\nWhen Islam spread through countries they would set up private churches and synagogues for the non Muslims they were governing and because of the good treatment they had received they themselves would convert. If one considers the small number of Muslims who initially spread Islam to the west all the way from Spain and Morocco and into east from India and China one would realize that such a small group of people could not force others to be members of a religion against their will.\n\nIt is also interesting to note that when the Mongols invaded and conquered large portions of the Islamic empire, instead of destroying the religion they adopted it!";
                Globals.factImage = "/Assets/swords8.png";
            }
            else if (flag == 3)
            {
                Globals.fact = "Women have no rights";
                Globals.factCorrection = "The image of a woman wearing a veil from head to toe, a woman who gets unfair justice or a woman who is not allowed to drive is an all too familiar notion when it comes to women treatment in Islam. And while there are Muslim countries in the world that do implement many harsh rulings against women, this should not be portrayed as Islamic law. Many of these countries have cultural differences that go against the teachings of Islam.\n\nIt should be noted that during pre-Islam Arabia women were used for fornication only and had no independence. The birth of a daughter in a family was considered humiliating and the practice of female infanticide was uncontrolled.\n\nWhen Islam came to being, verses in the Quran condemned the practice of female infanticide. Islam gave back many human rights to the woman and Muhammad(s) was even reported saying that “women are the twin halves of men.” A Muslim woman is allowed to reject and accept any suitor for marriage and has the right to seek divorce.\n\nThere is nothing in Islam that forbids a Muslim woman from exiting her house and is allowed to drive. Also in regards to education, a woman is obligated to seek knowledge and it is considered a sin if she refuses.";
                Globals.factImage = "/Assets/female179.png";
            }
            else if (flag == 4)
            {
                Globals.fact = "Muslims are barbaric during war";
                Globals.factCorrection = "Quite the contrary, when it comes to the conduct of war there are ten rules that every Muslim army must obey:\n\n1.Do not commit treachery \n2.Do not deviate from the right path\n3.Do not mutilate dead bodies\n4.Do not kill children\n5.Do not kill women\n6.Do not kill aged men\n7.Do not harm or burn trees\n8.Do not destroy buildings\n9.Do not destroy an enemy’s flock, unless you use it for your food\n10.When you pass people who have devoted their lives to monastic services leave them alone\n\nDuring the crusades when Saladin defeated the franks he honored the defeated Frankish army and supplied them with food and during the third crusade when Saladin’s enemy king Richard fell sick, Saladin sent him a gift of fruits and horses.";
                Globals.factImage = "/Assets/man64.png";
            }
            else if (flag == 5)
            {
                Globals.fact = "Child Bride";
                Globals.factCorrection = "While it is true that he married a girl that was at the age of nine that does not constitute pedophilia.\n\nHistorically, the age at which a girl was considered ready to be married has been puberty. This was the case in Biblical times, and is still used today to determine the age of marriage in many parts of the world. This was part of the norm and is not something that Islam invented. The girl he got married to had reached puberty 3 years before marriage.\n\nIt is upon reaching the age of puberty that a person, man or woman, becomes legally responsible for their actions under Islamic law.\n\nAt this point, they are allowed to make their own decisions and are held accountable for their actions. It should also be mentioned that in Islam, it is unlawful to force someone to marry someone that they do not want to marry. There is no indication that the society at that time criticized this marriage due to the girl’s young age.\n\nOn the contrary, the marriage was encouraged by the girl’s family and was welcomed by the community at large.";
                Globals.factImage = "/Assets/children.png";
            }
            else if (flag == 6)
            {
                Globals.fact = "Islamic Jihad";
                Globals.factCorrection = "The true Arabic meaning of the word jihad is struggle. However in Islam it is often used to describe the striving in the way of god.\n\nThere are many forms of jihad but the most important ones are Jihad al-nafs (jihad against ones self), jihad bil-lisan (jihad by being vocal), jihad bil yad (jihad by using action), and Jihad bis saif (jihad by using the sword).\n\nEach jihad is ranked differently and it was reported that Muhammad returned from a battle and said “We have returned from the lesser jihad (going into battle) to the greater jihad (the struggle of the soul).” This means that a Muslim struggling against himself and his soul is more important than the jihad of going into war. Another misconception is that only when a person dies in war does that person becomes a martyr.\n\nThis is, however, false and it is believed that anyone doing anything for the sake of god and is killed becomes a martyr. A person who dies while performing pilgrimage in Mecca, a woman who dies while giving birth, or even someone who dies in a car crash while he was on his way to the mosque are all considered martyrs.";
                Globals.factImage = "/Assets/clenched.png";
            }
            else if (flag == 7)
            {
                Globals.fact = "Religious Intolerance";
                Globals.factCorrection = "‘Kill the infidel’ is the phrase many people believe is the ideology that Muslims have towards the non Muslims. This, though, is not a correct portrayal of Islamic law. Islam has always given respect and freedom of religion to all faiths.\n\nIn the Quran it says “God does not forbid you, with regards to those who fight you not for religion nor drive you away out of your homes, from dealing kindly and justly with them, for god loves those who are just.”\n\nThere are many historical examples of Muslim tolerance towards other faith. One such example was when the caliph Umar was ruler of Jerusalem from 634 to 644 AD. He granted freedom to all religious communities and said that the inhabitants of his city were safe and that their places of worship would never be taken away from them.\n\nHe also set up courts that were designated to the non Muslim minorities. Whenever he would visit holy areas he would ask for the Christian patriarch Sophronius to accompany him.";
                Globals.factImage = "/Assets/bible5.png";
            }
            else if (flag == 8)
            {
                Globals.fact = "Children have no rights";
                Globals.factCorrection = "Children, according to Islamic law, have various rights. One of these is the right to be properly brought up, raised, and educated. Islam encourages children to be brought up well because it is the responsibility of an adult to raise his child to become a moral and ethical adult.\n\nChildren must also be treated equally. When giving financial gifts they should all be the same amount and there should be no preference among them.\n\nChildren are even permitted to take moderately from their parent’s wealth to sustain themselves if the parent declines to give them proper funds for living.\n\nA child is also not allowed to get hit in the face or hit by anything larger than a pencil.";
                Globals.factImage = "/Assets/kids1.png";
            }
            else if (flag == 9)
            {
                Globals.fact = "Muslims Hate Jesus";
                Globals.factCorrection = "There are many similarities between the historical references of Christianity and Islam. Many people are amazed to find out that according to Muslim belief, Jesus is one of the greatest messengers of God. One cannot be a Muslim without believing in the virgin birth and the many miracles of Jesus Christ.\n\nJesus is also mentioned in many verses of the Quran and is often used as an example of good virtue and character.\n\nHowever, the main difference between Christianity and Islam is that Muslims do not believe that Jesus was God.\n\n\n\n";
                Globals.factImage = "/Assets/rio2.png";
            }
            else if (flag == 10)
            {
                Globals.fact = "All Muslims are Arabs";
                Globals.factCorrection = "The common image of a Muslim is a turbaned dark Arab man with a long beard.\n\nHowever this image is part of the minority of Muslims.\n\nArabs make only 15% of the world’s Muslim population.\n\nAs a matter of fact the Middle East comes in third with East Asia coming in at first (69%) and Africa (27%) coming in at second.\n\nAnother common misconception is that all Arabs are Muslims. While the vast majority of Arabs are Muslims (75%), there are many other religions that Arabs practice including Christianity and Judaism.\n\n\n\n";
                Globals.factImage = "/Assets/Islamic_3-512.png";
            }
        }

        #region NavigationHelper registration

        /// <summary>
        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// <para>
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="NavigationHelper.LoadState"/>
        /// and <see cref="NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.
        /// </para>
        /// </summary>
        /// <param name="e">Provides data for navigation methods and event
        /// handlers that cannot cancel the navigation request.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedFrom(e);
        }

        #endregion
    }
}
