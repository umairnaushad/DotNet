
pipeline {

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