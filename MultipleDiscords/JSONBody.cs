using System;
using System.Collections.Generic;

namespace MultipleDiscords
{
    internal class MessageBody
    {
        public string content { get; set; }
    }

    internal class RepostCommandBody {
        public int type { get; set; } = 2;
        public long application_id { get; set; } = 844623994967818250;
        public long channel_id { get; set; } = 1085148797702778970;
        public int session_id = 0;
        public RepostCommandData data = new RepostCommandData();
    }

    public class RepostCommandData {
        public long version { get; set; } = 923489527027359775;
        public long id { get; set; } = 923489527027359774;
        public string name { get; set; } = "repost";
    }

    internal class ConfirmCommandBody {
        public int type { get; set; } = 3;
        public long channel_id { get; set; } = 1085148797702778970;
        public long message_id { get; set; } = 1085450564265054268;

        public long application_id { get; set; } = 844623994967818250;
        public int session_id = 0;
        public ConfirmCommandData data = new ConfirmCommandData();
    }

    public class ConfirmCommandData { 
        public int component_type { get; set; } = 2;
        public string custom_id { get; set; } = "confirmPost";
    }

    public class Author
    {
        public string id { get; set; }
        public string username { get; set; }
        public object display_name { get; set; }
        public string avatar { get; set; }
        public object avatar_decoration { get; set; }
        public string discriminator { get; set; }
        public int public_flags { get; set; }
        public bool bot { get; set; }
    }

    public class Component
    {
        public int type { get; set; }
        public List<Component> components { get; set; }
        public int style { get; set; }
        public string label { get; set; }
        public string custom_id { get; set; }
    }

    public class Embed
    {
        public string type { get; set; }
        public string description { get; set; }
        public int color { get; set; }
        public Image image { get; set; }
    }

    public class Image
    {
        public string url { get; set; }
        public string proxy_url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Root
    {
        public string id { get; set; }
        public int type { get; set; }
        public string content { get; set; }
        public string channel_id { get; set; }
        public Author author { get; set; }
        public List<object> attachments { get; set; }
        public List<Embed> embeds { get; set; }
        public List<object> mentions { get; set; }
        public List<object> mention_roles { get; set; }
        public bool pinned { get; set; }
        public bool mention_everyone { get; set; }
        public bool tts { get; set; }
        public DateTime timestamp { get; set; }
        public object edited_timestamp { get; set; }
        public int flags { get; set; }
        public List<Component> components { get; set; }
    }


}
