using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class SyncStress : MonoBehaviour 
{
    public Flowchart flowchart;
    public Slider slider;
    
    // Nouveaux éléments pour la couleur
    public Image fillImage;     // L'image qui se remplit
    public Gradient gradient;   // Le dégradé de couleurs que tu vas dessiner

    void Update() 
    {
        // 1. Récupère la valeur de Fungus
        int currentStress = flowchart.GetIntegerVariable("Stress");
        
        // 2. Met à jour la position de la barre
        slider.value = currentStress;

        // 3. Change la couleur
        // On divise par 100f pour avoir un chiffre entre 0 et 1 (ex: 30 devient 0.3)
        // Le Gradient va regarder à "0.3" quelle couleur il doit afficher
        fillImage.color = gradient.Evaluate(currentStress / 100f);
    }
}