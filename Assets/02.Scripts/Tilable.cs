using UnityEngine;

public class Tilable : MonoBehaviour
{
    private String name;
    private String climate;

    public Tilable(
        String name, String climate
    ) {
        this.name = name;
        this.climate = climate;
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    String get_name() { return name; }
    String get_climate() { return climate; }
}
