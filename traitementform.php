<?php

function validerNom($nom)
{
    if (empty($nom)) {
        return "Ce champ n'a pas été complété !";
    }
    $nom = htmlspecialchars($nom);
    $nbchar = strlen($nom);
    if ($nbchar >= 2 && $nbchar <= 255) {
        return "";
    } else {
        return "Ce champ n'est pas valide !";
    }
}

function validerPrenom($prenom)
{
    if (!empty($prenom)) {
        $prenom = htmlspecialchars($prenom);
        $nbchar = strlen($prenom);
        if ($nbchar >= 2 && $nbchar <= 255) {
            return "";
        } else {
            return "Ce champ n'est pas valide";
        }
    }
    return "";
}

function validerEmail($email)
{
    if (empty($email)) {
        return "L'adresse email n'a pas été complétée.";
    }
    $email = htmlspecialchars($email);
    if (filter_var($email, FILTER_VALIDATE_EMAIL)) {
        return "";
    } else {
        return "L'adresse email n'est pas valide.";
    }
}

function validerMessage($message)
{
    if (empty($message)) {
        return "Ce champ n'a pas été complété.";
    }
    $message = htmlspecialchars($message);
    $nbchar = strlen($message);
    if ($nbchar >= 10 && $nbchar <= 3000) {
        return "";
    } else {
        return "Ce champ n'est pas valide";
    }
}

//Traitement du formulaire

//Généré un tableau qui va stocker les eventuelles erreurs, un autre qui va stocker les bonnes valeurs si pas d'erreurs Ensuite afficher le tableau dans contact.php



function traitementformulaire()
{
    $arrayErrors = [];
    $arrayValeurs = [];

    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        $arrayErrors['nom'] = validerNom($_POST['nom']);
        if (empty($arrayErrors['nom'])) {
            $arrayValeurs['nom'] = htmlspecialchars($_POST['nom']);
        }

        $arrayErrors['prenom'] = validerPrenom($_POST['prenom']);
        if (empty($arrayErrors['prenom'])) {
            $arrayValeurs['prenom'] = htmlspecialchars($_POST['prenom']);
        }

        $arrayErrors['email'] = validerEmail($_POST['email']);
        if (empty($arrayErrors['email'])) {
            $arrayValeurs['email'] = htmlspecialchars($_POST['email']);
        }

        $arrayErrors['message'] = validerMessage($_POST['message']);
        if (empty($arrayErrors['message'])) {
            $arrayValeurs['message'] = htmlspecialchars($_POST['message']);
        }
    }
    return [$arrayErrors, $arrayValeurs];
}
