describe('Sign In And Register Test', () => {
  it('should_login_as_an_admin', () => {
    login("admin@admin.com", "Admin@123", "http://localhost:5246/signIn");
    cy.url().should('eq', "http://localhost:5246/contract");
  });
})

describe('Sign In And Register Test', () => {
  it('should_register_and_login_correct', () => {
    const expectedUrlPattern = /http:\/\/localhost:5246\/LeverancierDossierScherm\/[a-f0-9\-]+/;

    var email = "thomas.pijper@gmail.com";
    var password = "Admin@123";
    var User =
    {
        "User": {
            "FirstName": "Thomas",
            "LastName": "Pijper",
            "Email": "thomas.pijper2@gmail.com",
            "Password": password,
            "ConfirmPassword": password,
            "Kvk": "9823749987",
            "btwnummer": "9823749987",
            "rekeningnummer": "9823749987",
            "telefoonnummer": "9823749987",
            "postcode": "2402 MT",
            "huisnummer": "56",
            "straat": "Havixhorst",
            "provincie": "Zuid-Holland",
            "candidateDto": {
                "dateOfBirth": "2024-05-30T09:51:12.150Z",
                "bsn": "45345435",
                "createdDate": "2024-05-30T09:51:12.150Z",
                "updatedDate": "2024-05-30T09:51:12.150Z"
            }
        }
    }

    register(User);
    login(email, password);
    cy.url().should('match', expectedUrlPattern);
  })
})

function register(user){
  cy.wait(1000);
  cy.visit('http://localhost:5246/');
  cy.get('.registerButton').click();

  cy.get("#email").type(user.User.Email);
  cy.get('#email').clear();
  cy.get("#email").type(user.User.Email);

  cy.get("#mainpassword").type(user.User.Password);
  cy.get("#repassword").type(user.User.Password);

  cy.get(".next-button").click();

  cy.get("#input-voornaam").type(user.User.FirstName);
  cy.get("#input-achternaam").type(user.User.LastName);
  cy.get("#geboortedatum").clear();
  cy.get("#geboortedatum").type(user.User.candidateDto.dateOfBirth);
  cy.get("#servicenummer").type(user.User.candidateDto.bsn);

  cy.get(".next-button").click();

  cy.get("#kvk").type(user.User.Kvk);
  cy.get("#btwnummer").type(user.User.btwnummer);
  cy.get("#rekeningnummer").type(user.User.rekeningnummer);
  cy.get("#telefoonnummer").type(user.User.telefoonnummer);

  cy.get("#postcode").type(user.User.postcode);
  cy.get("#huisnummer").type(user.User.huisnummer);
  cy.get("#straat").type(user.User.straat);
  cy.get("#provincie").type(user.User.provincie);

  cy.get(".next-button").click();
  cy.get(".next-button").click();
}


function login(email, password){
    cy.visit('http://localhost:5246/');

    cy.get('.signInButton').click();

    cy.get('#email').type(email);
    cy.get('#email').clear();
    cy.get('#email').type(email);

    cy.get('.password-input').type(password);

    cy.get('.login-button').click();
}
