using MonoBehaviorInheritors.Panorama;
using UnityEngine;

namespace MonoBehaviorInheritors.Main
{
    public class LocationsController : MonoBehaviour
    {
        [SerializeField] private GameObject[] _panoramaPrefabs;
        [SerializeField] private GameObject _panoramaCameraPrefab;
        private Location[] _locations;
        public Location CurrentLocation { get; set; }

        private void Awake()
        {
            _locations = new Location[_panoramaPrefabs.Length];
            for (int i = 0; i < _panoramaPrefabs.Length; i++)
            {
                _locations[i] = new Location(_panoramaPrefabs[i].name);
            }
            CurrentLocation = ReturnLocationByName("Meadow");
            GameObject instantiatedLocation = Instantiate(ReturnLocationPrefab(CurrentLocation));
            GameObject panoramaCamera = Instantiate(_panoramaCameraPrefab);
            panoramaCamera.transform.SetParent(instantiatedLocation.transform);
            instantiatedLocation.GetComponent<PanoramaInitializer>().Initialize();
            instantiatedLocation.GetComponent<Animator>().SetTrigger("FullOpaque");
            FindObjectOfType<EventThrower>().Camera = panoramaCamera.GetComponent<Camera>();
        }

        private Location ReturnLocationByName(string locationName)
        {
            foreach (Location location in _locations)
            {
                if (locationName == location.Name)
                {
                    return location;
                }
            }
            return null;
        }

        private GameObject ReturnLocationPrefab(Location location)
        {
            foreach (GameObject panoramaPrefab in _panoramaPrefabs)
            {
                if (panoramaPrefab.name == location.Name)
                {
                    return panoramaPrefab;
                }
            }
            return null;
        }

    }
}