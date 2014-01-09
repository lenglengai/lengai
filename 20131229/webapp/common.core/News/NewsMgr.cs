using System.Collections.Generic;

namespace common.core
{
    public class NewsMgr : IHeadstream
    {
        public void _headSerialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mNews, "news");
        }

        public string _streamName()
        {
            return "newsMgr";
        }

        public void _clearNews()
        {
            mNews.Clear();
        }

        public void _addNews(News nNews)
        {
            mNews.Add(nNews);
        }

        public NewsMgr()
        {
            mNews = new List<News>();
        }

        List<News> mNews;
    }
}
