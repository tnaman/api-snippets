<?php
require_once './vendor/autoload.php';
use Twilio\TwiML\VoiceResponse;

$response = new VoiceResponse();
$dial = $response->dial('', ['record' => 'record-from-ringing']);
$dial->sim('DE8caa2afb9d5279926619c458dc7098a8');

echo $response;
