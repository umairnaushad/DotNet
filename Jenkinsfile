
pipeline {

    options {
        buildDiscarder logRotator(numToKeepStr: '3')
    }

    agent any

    stages {
        stage("Pipeline Info") {
            steps {
                echo "Welcome "
                echo 'Pulling...' + env.BRANCH_NAME
                echo sh(returnStdout: true, script: 'env')
            }
        }
    }
}