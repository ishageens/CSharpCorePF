using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CSharpCorePFOefenmap
{
    [Serializable]
    public class Tweets
    {
        private List<Tweet> tweetlijstValue;

        public ReadOnlyCollection<Tweet> AlleTweets
        {
            get
            {
                return new ReadOnlyCollection<Tweet>(tweetlijstValue);
            }
        }

        public void AddTweet(Tweet tweet)
        {
            if (tweetlijstValue == null)
                tweetlijstValue = new List<Tweet>();
            tweetlijstValue.Add(tweet);
        }
    }
}
