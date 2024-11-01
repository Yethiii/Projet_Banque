<?php require_once __DIR__ . DIRECTORY_SEPARATOR . 'header.php';
require_once __DIR__ . DIRECTORY_SEPARATOR . 'traitementform.php';

$arrayTraitement = traitementformulaire();
$arrayErrors = $arrayTraitement[0];
$arrayValeurs = $arrayTraitement[1];
?>

<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    if (empty(array_filter($arrayErrors))) {
        $arrayValeurs = [];
    }
}

?>

<h2>Contact</h2>


<form method="POST" action="">

    <label for="nom">Votre nom * :</label>
    <input type="text" name="nom" placeholder="Votre nom ici !" id="nom" value=<?= htmlspecialchars($arrayValeurs["nom"] ?? "") ?>>
    <br>
    <?= $arrayErrors['nom'] ?? '' ?>
    <br><br>

    <label for="prenom">Votre prénom :</label>
    <input type="text" name="prenom" placeholder="Votre prénom ici !" id="prenom" minlength="2" maxlength="255" value=<?= htmlspecialchars($arrayValeurs["prenom"] ?? "") ?>>
    <br>
    <?= $arrayErrors['prenom'] ?? '' ?>
    <br><br>
    <label for="email">Votre e-mail * :</label>
    <input type="email" name="email" placeholder="Votre e-mail ici !" id="email" required value="<?= htmlspecialchars($arrayValeurs["email"] ?? "") ?>">
    <br>
    <?= $arrayErrors['email'] ?? '' ?>

    <br><br>
    <label for="message">Votre message * :</label>
    <textarea name="message" placeholder="Ecrivez votre message ici!" id="message" required minlength="10" maxlength="3000"><?= htmlspecialchars($arrayValeurs["message"] ?? "") ?></textarea>
    <br>
    <?= $arrayErrors['message'] ?? '' ?>
    <br>
    <p> Les champs marqués d'une * sont obligatoires ! </p>
    <br>
    <button type=" submit">Envoyer mon message</button>

</form>

<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    if (empty(array_filter($arrayErrors))) {
        echo "<p>Le formulaire a été envoyé !</p>";
    } else {
        echo "<p>Le formulaire n'a pas été envoyé !</p>";
    }
}
?>

<?php require_once __DIR__ . DIRECTORY_SEPARATOR . 'footer.php'; ?>