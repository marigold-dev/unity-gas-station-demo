using Beacon.Sdk.Beacon.Permission;
using UnityEngine;

namespace TezosSDK.Samples.DemoExample
{
    public class ExampleFactory : MonoBehaviour
    {
        public static ExampleFactory Instance;
        private IExampleManager _exampleManager = null;

        [field: SerializeField]
        private string contractAddress;

        [field: SerializeField]
        private string gasStationUrl;

        [field: SerializeField]
        private string rpcBaseUrl;

        [field: SerializeField]
        private NetworkType Network;

        private void Awake()
        {
            if (Instance == null)
                Instance = this;
            else if (Instance != this)
                Destroy(this);

            _exampleManager = new ExampleManager(contractAddress, gasStationUrl, rpcBaseUrl, Network);
            _exampleManager.Init();
        }

        public IExampleManager GetExampleManager()
        {
            return _exampleManager;
        }
    }
}