using VkNet;
using VkNet.Model;

namespace Heute
{
    class APIwk
    {
        static VkApi api = new VkApi();
        public static void Token()
        {
            api.Authorize(new ApiAuthParams
            {
                AccessToken = "access_token"
            });
        }
        public static void Messg()
        {
            api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams
            {
                PeerId = 0,
                Message = "а"
            });
        }
    }
}
