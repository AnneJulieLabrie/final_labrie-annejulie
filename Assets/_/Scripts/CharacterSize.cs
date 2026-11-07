using System.Collections;
using UnityEngine;
using StarterAssets;
using Unity.Cinemachine;

public class Taille : MonoBehaviour
{
    [SerializeField] CinemachineThirdPersonFollow suiviCamera;
    [SerializeField] float dureeTransition = 0.4f;

    ThirdPersonController controleur;
    CharacterController capsule;
    CinemachineCamera cam;

    // Valeurs d'origine (taille 1)
    float vitesseBase, sprintBase, sautBase, offsetBase, rayonBase;
    float stepBase, skinBase;
    float distanceBase, brasBase, rayonCameraBase, nearClipBase;
    Vector3 epauleBase;

    void Awake()
    {
        controleur = GetComponent<ThirdPersonController>();
        capsule = GetComponent<CharacterController>();
        cam = suiviCamera.GetComponent<CinemachineCamera>();

        vitesseBase = controleur.MoveSpeed;
        sprintBase = controleur.SprintSpeed;
        sautBase = controleur.JumpHeight;
        offsetBase = controleur.GroundedOffset;
        rayonBase = controleur.GroundedRadius;

        stepBase = capsule.stepOffset;
        skinBase = capsule.skinWidth;

        distanceBase = suiviCamera.CameraDistance;
        epauleBase = suiviCamera.ShoulderOffset;
        brasBase = suiviCamera.VerticalArmLength;
        rayonCameraBase = suiviCamera.AvoidObstacles.CameraRadius;
        nearClipBase = cam.Lens.NearClipPlane;
    }

    public void ChangerTaille(float facteur)   // 0.1 = réduit de 90 %
    {
        StopAllCoroutines();
        StartCoroutine(Transition(facteur));
    }

    IEnumerator Transition(float facteur)
    {
        float depart = transform.localScale.x;
        for (float t = 0; t < dureeTransition; t += Time.deltaTime)
        {
            Appliquer(Mathf.Lerp(depart, facteur, t / dureeTransition));
            yield return null;
        }
        Appliquer(facteur);
    }

    void Appliquer(float f)
    {
        transform.localScale = Vector3.one * f;

        // Contrôleur
        controleur.MoveSpeed = vitesseBase * f;
        controleur.SprintSpeed = sprintBase * f;
        controleur.JumpHeight = sautBase * f;
        controleur.GroundedOffset = offsetBase * f;
        controleur.GroundedRadius = rayonBase * f;

        // Capsule : ces deux valeurs ne suivent pas l'échelle du transform
        capsule.stepOffset = stepBase * f;
        capsule.skinWidth = skinBase * f;

        // Caméra
        suiviCamera.CameraDistance = distanceBase * f;
        suiviCamera.ShoulderOffset = epauleBase * f;
        suiviCamera.VerticalArmLength = brasBase * f;
        suiviCamera.AvoidObstacles.CameraRadius = rayonCameraBase * f;
        cam.Lens.NearClipPlane = nearClipBase * f;
    }
}
