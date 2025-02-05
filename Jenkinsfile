pipeline {
    agent any
    environment {
        UNITY_PATH = "G:/Unity Editors/2022.3.50f1/Editor/Unity.exe"
    }

    stages {
        stage('Checkout') {
            steps {
                git credentialsId: 'GITHUB_CREDENTIALS_ID', url: 'https://github.com/Mieku/DevOps-Learning.git', branch: 'main'
            }
        }
        stage('Build Windows') {
            steps {
                bat "\"${UNITY_PATH}\" -batchmode -quit -executeMethod BuildScript.BuildGame -logFile build.log"
            }
        }
        stage('Archive Build') {
            steps {
                archiveArtifacts artifacts: '**/Builds/**/*', fingerprint: true
            }
        }
    }
}